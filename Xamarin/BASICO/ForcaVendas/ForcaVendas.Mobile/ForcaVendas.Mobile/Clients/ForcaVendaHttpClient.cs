using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ForcaVendas.Mobile.Clients
{
    class ForcaVendaHttpClient
    {
        private static Lazy<ForcaVendaHttpClient> _Lazy = new Lazy<ForcaVendaHttpClient>(() => new ForcaVendaHttpClient());

        public static ForcaVendaHttpClient Current { get => _Lazy.Value; }

        private ForcaVendaHttpClient()
        {
            _HttpClient = new HttpClient
            {
                BaseAddress = new Uri("https://treinamento-xamarin.azurewebsites.net/api/")
            };
        }

        private readonly HttpClient _HttpClient;
        
        #region [ GET ]

        public async Task GetAsync(string requestUri)
        {
            try
            {
                using (var _response = await _HttpClient.GetAsync(requestUri.StartsWith("/") ? requestUri : $"/{requestUri}"))
                {
                    if (!_response.IsSuccessStatusCode)
                        throw new InvalidOperationException();
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<TResult> GetAsync<TResult>(string requestUri)
        {
            try
            {
                using (var _response = await _HttpClient.GetAsync(requestUri.StartsWith("/") ? requestUri.Substring(1) : $"{requestUri}"))
                {
                    if (!_response.IsSuccessStatusCode)
                        throw new InvalidOperationException();

                    var _responseContent = await _response.Content.ReadAsStringAsync();

                    if (string.IsNullOrWhiteSpace(_responseContent))
                        throw new InvalidOperationException();

                    return JsonConvert.DeserializeObject<TResult>(_responseContent);
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        #endregion

        #region [ POST ]

        internal async Task PostAsync(string requestUri, HttpContent content, double timeout = 40)
        {
            try
            {
                _HttpClient.Timeout = TimeSpan.FromSeconds(timeout);

                using (var _response = await _HttpClient.PostAsync(requestUri.StartsWith("/") ? requestUri.Substring(1) : requestUri, content))
                {
                    if (!_response.IsSuccessStatusCode)
                        throw new InvalidOperationException();

                    return;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        internal async Task<TResult> PostAsync<TResult>(string requestUri, HttpContent pContent, double pTimeout = 40)
        {
            try
            {
                _HttpClient.Timeout = TimeSpan.FromSeconds(pTimeout);

                using (var _response = await _HttpClient.PostAsync(requestUri.StartsWith("/") ? requestUri.Substring(1) : requestUri, pContent))
                {
                    if (!_response.IsSuccessStatusCode)
                        throw new InvalidOperationException();

                    var _responseContent = await _response.Content.ReadAsStringAsync();

                    if (string.IsNullOrWhiteSpace(_responseContent))
                        throw new InvalidOperationException();

                    return JsonConvert.DeserializeObject<TResult>(_responseContent);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }



        internal Task PostJsonAsync(string requestUri, object content, double timeout = 40) => PostAsync(requestUri, new StringContent(JsonConvert.SerializeObject(content), Encoding.UTF8, "application/json"), timeout);

        internal Task<TResult> PostJsonAsync<TResult>(string requestUri, object content, double timeout = 40) => PostAsync<TResult>(requestUri, new StringContent(JsonConvert.SerializeObject(content), Encoding.UTF8, "application/json"), timeout);

        #endregion

        #region [ PUT ]

        internal async Task<TResult> PutAsync<TResult>(string requestUri, HttpContent pContent, double pTimeout = 40)
        {
            try
            {
                _HttpClient.Timeout = TimeSpan.FromSeconds(pTimeout);

                using (var _response = await _HttpClient.PutAsync(requestUri.StartsWith("/") ? requestUri.Substring(1) : requestUri, pContent))
                {
                    if (!_response.IsSuccessStatusCode)
                        throw new InvalidOperationException();

                    var _responseContent = await _response.Content.ReadAsStringAsync();

                    if (string.IsNullOrWhiteSpace(_responseContent))
                        throw new InvalidOperationException();

                    return JsonConvert.DeserializeObject<TResult>(_responseContent);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        internal Task<TResult> PutJsonAsync<TResult>(string requestUri, object content, double timeout = 40) => PutAsync<TResult>(requestUri, new StringContent(JsonConvert.SerializeObject(content), Encoding.UTF8, "application/json"), timeout);

        #endregion
    }
}
