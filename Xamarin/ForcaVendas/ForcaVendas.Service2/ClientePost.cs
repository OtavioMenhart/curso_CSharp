
using System.IO;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Azure.WebJobs.Host;
using Newtonsoft.Json;
using System;

namespace ForcaVendas.Service2
{
    public static class ClientePost
    {
        [FunctionName(nameof(ClientePost))]
        public static IActionResult Run(
            [HttpTrigger(
            AuthorizationLevel.Anonymous,
            "POST",
            Route = "cliente")]HttpRequest req,
            TraceWriter log)
        {
            log.Info("C# HTTP trigger function processed a request.");

            string requestBody = new StreamReader(req.Body).ReadToEnd();
            var cliente = JsonConvert.DeserializeObject<ClienteDto>(requestBody);

            cliente.DataAlteracao = DateTime.UtcNow.AddHours(1);

            return new JsonResult(cliente);
        }
    }
}
