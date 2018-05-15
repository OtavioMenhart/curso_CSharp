using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ServicoWebAPI.Models;

namespace ServicoWebAPI.Controllers
{
    public class ClienteController : ApiController
    {
        Cliente[] clientes = new Cliente[]
        {
            new Cliente(){ ID = 1, Nome = "Otávio", EMail = "otaviomenhart@hotmail.com" },
            new Cliente(){ ID = 2, Nome = "Teste", EMail = "teste@gmail.com"},
            new Cliente(){ ID = 3, Nome = "Teste3", EMail = "teste3@gmail.com"}
        };

        public IEnumerable<Cliente> getClientes()
        {
            return clientes;
        }

        //rota
        public IHttpActionResult getCliente(int id)
        {
            var cli = clientes.FirstOrDefault((c) => c.ID == id);
            return Ok(cli);
        }
    }
}
