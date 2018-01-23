using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Models
{
    public class Servicos
    {
        private int id;
        private string nome_servico;
        private int valor_final;

        private Servicos()
        {

        }

        public Servicos(int id, string nome_servico, int valo_final)
        {

            this.Id = id;
            this.Nome_servico = nome_servico;
            this.Valor_final = valor_final;
        }

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }

        public string Nome_servico
        {
            get
            {
                return nome_servico;
            }

            set
            {
                nome_servico = value;
            }
        }

        public int Valor_final
        {
            get
            {
                return valor_final;
            }

            set
            {
                valor_final = value;
            }
        }

    }


}
