using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using App15_JWTAsync.Model;

namespace App15_JWTAsync.Service
{
    public class JWTService
    {
        private static string baseURL = "http://ws.spacedu.com.br/xf2018/rest/apix";
        private static string token;
        private static string tokenType;
        public async static Task<string> GetToken(string nome, string password)
        {
            var URL = baseURL + "/token";
            HttpClient requisicao = new HttpClient();

            var parametros = new FormUrlEncodedContent(new[] {
                new KeyValuePair<string, string>("nome", nome),
                new KeyValuePair<string, string>("password", password)
            });

            var resposta = await requisicao.PostAsync(URL, parametros);

            if(resposta.StatusCode == HttpStatusCode.OK)
            {
                var respostaToken =  JsonConvert.DeserializeObject<RespostaToken>(resposta.Content.ReadAsStringAsync().GetAwaiter().GetResult());
                token = respostaToken.access_token;
                tokenType = respostaToken.token_type;
                return token;
            }
            else
            {
                return resposta.Content.ReadAsStringAsync().GetAwaiter().GetResult();
            }
        }

        public async static Task<string> Verificar()
        {
            var URL = baseURL + "/verify";
            HttpClient requisicao = new HttpClient();
            requisicao.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue(tokenType, token);

            var resposta = await requisicao.GetAsync(URL);

            if (resposta.StatusCode == HttpStatusCode.OK)
            {
                var respostaToken = JsonConvert.DeserializeObject<RespostaVerificar>(resposta.Content.ReadAsStringAsync().GetAwaiter().GetResult());
                return respostaToken.usuario.nome + " " + respostaToken.usuario.id;
            }
            else
            {
                return resposta.Content.ReadAsStringAsync().GetAwaiter().GetResult();
            }
        }
    }
}
