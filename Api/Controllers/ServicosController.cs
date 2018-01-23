using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Api.Models;

namespace Api.Controllers
{
    [RoutePrefix("api/servicos")]
    public class ServicosController : ApiController
    {
        private static List<Servicos> listaServicos = new List<Servicos>();

        [AcceptVerbs("POST")]
        [Route("CadastrarSevicos")]
        public string CadastrarCliente(Servicos servicos)
        {
            listaServicos.Add(servicos);

            return "Serviços cadastrado com sucesso!";
        }

        [AcceptVerbs("GET")]
        [Route("ConsultarServicos/{servicos}")]
        public Servicos ConsultarServicosPorId(int id)
        {
            Servicos servicos = listaServicos.Where(n => n.Id == id)
                                                .Select(n => n)
                                                .FirstOrDefault();

            return servicos;
        }

        [AcceptVerbs("GET")]
        [Route("ConsultarServicos")]
        public List<Servicos> ConsultarServicos()
        {
            return listaServicos;
        }

    }
}
