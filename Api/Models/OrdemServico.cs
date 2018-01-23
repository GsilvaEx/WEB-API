using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Models
{
    public class OrdemServico
    {
        private int id_ordem;
        private int id_cliente;
        private int id_servico;
        private string data_contratacao;
        private string data_execucao;
        private int quantidade_servicos;

        private OrdemServico()
        {

        }

        public OrdemServico(int id_ordem, int id_cliente, int id_servico, string data_contratacao, string data_execucao, int quantidade_servicos)
        {
            this.Id_ordem = id_ordem;
            this.Id_cliente = id_cliente;
            this.Id_servico = id_servico;
            this.Data_contratacao = data_contratacao;
            this.Data_execucao = data_execucao;
            this.Quantidade_servicos = quantidade_servicos;
        }

        public int Id_ordem
        {
            get
            {
                return id_ordem;
            }

            set
            {
                id_ordem = value;
            }
        }

        public int Id_cliente
        {
            get
            {
                return id_cliente;
            }

            set
            {
                id_cliente = value;
            }
        }

        public int Id_servico
        {
            get
            {
                return id_servico;
            }

            set
            {
                id_servico = value;
            }
        }

        public string Data_contratacao
        {
            get
            {
                return data_contratacao;
            }

            set
            {
                data_contratacao = value;
            }
        }

        public string Data_execucao
        {
            get
            {
                return data_execucao;
            }

            set
            {
                data_execucao = value;
            }
        }

        public int Quantidade_servicos
        {
            get
            {
                return quantidade_servicos;
            }

            set
            {
                quantidade_servicos = value;
            }
        }


    }
}