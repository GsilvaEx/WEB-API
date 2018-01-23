using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Api.Models;

namespace Api.Controllers
{
    [RoutePrefix("api/ordemservico")]
    public class OrdemServicoController : ApiController
    {
        private static List<OrdemServico> listaOrdem = new List<OrdemServico>();

        [AcceptVerbs("POST")]
        [Route("CadastrarOrdem")]
        public string CadastrarOrdem(OrdemServico ordem)
        {
            listaOrdem.Add(ordem);

            return "Serviços cadastrado com sucesso!";
        }

        [AcceptVerbs("GET")]
        [Route("ConsultarOrdem/{ordem}")]
        public OrdemServico ConsultarOrdemPorId(int id_ordem)
        {
            OrdemServico ordem = listaOrdem.Where(n => n.Id_ordem == id_ordem)
                                                .Select(n => n)
                                                .FirstOrDefault();

            return ordem;
        }

        [AcceptVerbs("GET")]
        [Route("ConsultarOrdem")]
        public List<OrdemServico> ConsultarOrdens()
        {
            return listaOrdem;
        }
    }
}
