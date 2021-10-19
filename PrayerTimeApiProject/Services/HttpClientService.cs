using System;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using lesson10.Model;

namespace lesson10.Services
{
    public class HttpClientService
    {
        private readonly HttpClient _client;

        public HttpClientService()
        {
            _client = new HttpClient();
        }
        public async Task<HttpResult<T>> GetObjectAsync<T>(string url)
        {
            var uri = new Uri(url);
            var result = new HttpResult<T>() { IsSuccess = false };

            using var httpResponse = await _client.GetAsync(uri);

            if(httpResponse.IsSuccessStatusCode)
            {
                var jsonResponse = await httpResponse.Content.ReadAsStringAsync();
                T data = default(T);

                try
                {
                    data = JsonSerializer.Deserialize<T>(jsonResponse);
                }
                catch(JsonException e)
                {
                    result.ErrorMessage = 
                        $"Response message could not be parsed into {typeof(T)}. {e.Message}";
                    return result;
                }
                catch(Exception e)
                {
                    result.ErrorMessage = e.Message;
                    return result;
                }

                result.IsSuccess = true;
                result.Data = data;
                return result;
            }

            result.ErrorMessage = 
                $"Error occured with HTTP Request: {httpResponse.ReasonPhrase}";
            return result;
        }
    }
}