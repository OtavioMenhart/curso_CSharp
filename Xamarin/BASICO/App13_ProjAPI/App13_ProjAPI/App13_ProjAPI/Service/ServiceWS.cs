﻿using App13_ProjAPI.Model;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using Newtonsoft.Json;

namespace App13_ProjAPI.Service
{
    public class ServiceWS
    {
        private static string enderecoBase = "http://ws.spacedu.com.br/xf2018/rest/api";


        public static Usuario GetUsuario(Usuario usuario)
        {
            var URL = enderecoBase + "/usuario";

            //QueryString
            //StringContent param = new StringContent(string.Format("?nome={0}&password={1}", usuario.nome, usuario.password));

            FormUrlEncodedContent param = new FormUrlEncodedContent(new[] {
                new KeyValuePair<string,string>("nome", usuario.nome),
                new KeyValuePair<string,string>("password", usuario.password)
            });


            HttpClient requisicao = new HttpClient();
            HttpResponseMessage resposta = requisicao.PostAsync(URL, param).GetAwaiter().GetResult();

            if (resposta.StatusCode == HttpStatusCode.OK)
            {
                var conteudo = resposta.Content.ReadAsStringAsync().GetAwaiter().GetResult();
                //deserializar, retornar e salvar como login
                return JsonConvert.DeserializeObject<Usuario>(conteudo);
                
            }

            return null;
        }

        //PEGAR CHATS
        public static List<Chat> GetChat()
        {
            var URL = enderecoBase + "/chats";


            HttpClient requisicao = new HttpClient();
            HttpResponseMessage resposta = requisicao.GetAsync(URL).GetAwaiter().GetResult();

            if (resposta.StatusCode == HttpStatusCode.OK)
            {
                string conteudo = resposta.Content.ReadAsStringAsync().GetAwaiter().GetResult();

                if (conteudo.Length > 2)
                {
                    List<Chat> lista = JsonConvert.DeserializeObject<List<Chat>>(conteudo);
                    return lista;
                }
                else
                {
                    return null;
                }

            }
            else
            {
                return null;
            }

        }


        //INSERIR CHAT
        public static bool InsertChat(Chat chat)
        {
            var URL = enderecoBase + "/chat";


            FormUrlEncodedContent param = new FormUrlEncodedContent(new[] {
                new KeyValuePair<string,string>("nome", chat.nome)
            });


            HttpClient requisicao = new HttpClient();
            HttpResponseMessage resposta = requisicao.PostAsync(URL, param).GetAwaiter().GetResult();

            if (resposta.StatusCode == HttpStatusCode.OK)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //RENOMEAR CHAT
        public static bool RenomearChat(Chat chat)
        {
            var URL = enderecoBase + "/chat/" + chat.id;


            FormUrlEncodedContent param = new FormUrlEncodedContent(new[] {
                new KeyValuePair<string,string>("nome", chat.nome)
            });


            HttpClient requisicao = new HttpClient();
            HttpResponseMessage resposta = requisicao.PostAsync(URL, param).GetAwaiter().GetResult();

            if (resposta.StatusCode == HttpStatusCode.OK)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //DELETAR CHAT
        public static bool DeleteChat(Chat chat)
        {
            var URL = enderecoBase + "/chat/delete/" + chat.id;

            HttpClient requisicao = new HttpClient();
            HttpResponseMessage resposta = requisicao.DeleteAsync(URL).GetAwaiter().GetResult();

            if (resposta.StatusCode == HttpStatusCode.OK)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //GET MENSAGENS DO CHAT
        public static List<Mensagem> GetMensagensChat(Chat chat)
        {
            var URL = enderecoBase + "/chat/" + chat.id + "/msg";

            HttpClient requisicao = new HttpClient();
            HttpResponseMessage resposta = requisicao.GetAsync(URL).GetAwaiter().GetResult();

            if (resposta.StatusCode == HttpStatusCode.OK)
            {
                string conteudo = resposta.Content.ReadAsStringAsync().GetAwaiter().GetResult();

                if(conteudo.Length > 2)
                {
                    List<Mensagem> lista = JsonConvert.DeserializeObject<List<Mensagem>>(conteudo);
                    return lista;
                }
                else
                {
                    return null;
                }
                
            }
            else
            {
                return null;
            }
        }


        //INSERIR MSG
        public static bool InsertMensagem(Mensagem mensagem)
        {
            var URL = enderecoBase + "/chat/" + mensagem.id_chat + "/msg";

            FormUrlEncodedContent param = new FormUrlEncodedContent(new[] {
                new KeyValuePair<string,string>("mensagem", mensagem.mensagem),
                new KeyValuePair<string,string>("id_usuario", mensagem.id_usuario.ToString())
            });

            HttpClient requisicao = new HttpClient();
            HttpResponseMessage resposta = requisicao.PostAsync(URL, param).GetAwaiter().GetResult();

            if(resposta.StatusCode == HttpStatusCode.OK)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        //DELETAR MSG
        public static bool DeleteMensagem(Mensagem mensagem)
        {
            var URL = enderecoBase + "/chat/" + mensagem.id_chat + "/delete/" + mensagem.id;

            HttpClient requisicao = new HttpClient();
            HttpResponseMessage resposta = requisicao.DeleteAsync(URL).GetAwaiter().GetResult();

            if (resposta.StatusCode == HttpStatusCode.OK)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
