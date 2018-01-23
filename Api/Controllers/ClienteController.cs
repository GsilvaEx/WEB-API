using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Api.Models;


namespace Api.Controllers
{
    [RoutePrefix("api/cliente")]

    public class ClienteController : ApiController
    {

        private static List<Cliente> listaClientes = new List<Cliente>();


        [AcceptVerbs("POST")]
        [Route("CadastrarCliente")]
        public string CadastrarCliente(Cliente cliente)
        {
            listaClientes.Add(cliente);

            return "Cliente cadastrado com sucesso!";
        }

        [AcceptVerbs("GET")]
        [Route("ConsultarCliente/{cliente}")]
        public Cliente ConsultarClientePorId(int id)
        {
            Cliente cliente = listaClientes.Where(n => n.Id == id)
                                                .Select(n => n)
                                                .FirstOrDefault();

            return cliente;
        }

        [AcceptVerbs("GET")]
        [Route("ConsultarClientes")]
        public List<Cliente> ConsultarClientes()
        {
            return listaClientes;
        }
    }
}

