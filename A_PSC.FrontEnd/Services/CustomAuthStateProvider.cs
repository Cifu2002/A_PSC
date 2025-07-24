using A_PSC.Shared.DTOs;
using Blazored.LocalStorage;
using Microsoft.AspNetCore.Components.Authorization;
using System.Net.Http.Json;
using System.Security.Claims;
using System.Text.Json.Nodes;

namespace A_PSC.FrontEnd.Services
{
    public class CustomAuthStateProvider : AuthenticationStateProvider
    {
        private readonly HttpClient httpClient;
        private readonly ISyncLocalStorageService localStorage;

        public CustomAuthStateProvider(HttpClient httpClient, ISyncLocalStorageService localStorage)
        {
            this.httpClient = httpClient;
            this.localStorage = localStorage;

            var accessToken = localStorage.GetItem<string>("accessToken");
            if (!string.IsNullOrWhiteSpace(accessToken))
            {
                httpClient.DefaultRequestHeaders.Authorization =
                    new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
            }
        }

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var user = new ClaimsPrincipal(new ClaimsIdentity());

            try
            {
                var userInfo = await httpClient.GetFromJsonAsync<UserInfoDTO>("manage/info");
                if (userInfo is not null && !string.IsNullOrWhiteSpace(userInfo.Email))
                {
                    var claims = new List<Claim>
                    {
                        new(ClaimTypes.Name, userInfo.Email),
                        new(ClaimTypes.Email, userInfo.Email),
                    };

                    var identity = new ClaimsIdentity(claims, "Token");
                    user = new ClaimsPrincipal(identity);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Auth error: {ex.Message}");
            }

            return new AuthenticationState(user);
        }

        public async Task<FormResultDTO> LoginAsync(string email, string password)
        {
            try
            {
                var response = await httpClient.PostAsJsonAsync("login", new { email, password });

                if (response.IsSuccessStatusCode)
                {
                    var json = await response.Content.ReadFromJsonAsync<JsonObject>();
                    var accessToken = json?["accessToken"]?.ToString();
                    var refreshToken = json?["refreshToken"]?.ToString();

                    if (!string.IsNullOrEmpty(accessToken))
                    {
                        localStorage.SetItem("accessToken", accessToken!);
                        localStorage.SetItem("refreshToken", refreshToken!);
                        httpClient.DefaultRequestHeaders.Authorization =
                            new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);

                        NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());

                        return new FormResultDTO { Succeeded = true };
                    }
                }

                return new FormResultDTO { Succeeded = false, Errors = ["Correo o contraseña incorrectos"] };
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Login error: {ex.Message}");
                return new FormResultDTO { Succeeded = false, Errors = ["Connection error"] };
            }
        }

        public async Task<FormResultDTO> RegisterAsync(RegisterDTO registerDto)
        {
            try
            {
                var response = await httpClient.PostAsJsonAsync("register", registerDto);

                if (response.IsSuccessStatusCode)
                {
                    return await LoginAsync(registerDto.Email, registerDto.Password);
                }

                var json = await response.Content.ReadFromJsonAsync<JsonObject>();
                var errorsObject = json?["errors"]?.AsObject();
                var errors = new List<string>();

                if (errorsObject is not null)
                {
                    foreach (var entry in errorsObject)
                    {
                        foreach (var message in entry.Value!.AsArray())
                        {
                            errors.Add(message!.ToString());
                        }
                    }
                }

                return new FormResultDTO { Succeeded = false, Errors = errors.ToArray() };
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Register error: {ex.Message}");
                return new FormResultDTO { Succeeded = false, Errors = ["Connection error"] };
            }
        }

        public void Logout()
        {
            localStorage.RemoveItem("accessToken");
            localStorage.RemoveItem("refreshToken");
            httpClient.DefaultRequestHeaders.Authorization = null;
            NotifyAuthenticationStateChanged(GetAuthenticationStateAsync());
        }
    }
}
