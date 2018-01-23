using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api.Models
{
    public class Cliente
    {

        private int id;
        private string nome;
        private string email;
        private string data;
        private int t_celular;
        private int t_residencial;

        private Cliente()
        {

        }

        public Cliente(int id, string nome, string email, string data, int t_celular, int t_residencial)
        {
            this.Id = id;
            this.Nome = nome;
            this.Email = email;
            this.Data = data;
            this.T_celular = t_celular;
            this.T_residencial = t_residencial;
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

        public string Nome
        {
            get
            {
                return nome;
            }

            set
            {
                nome = value;
            }
        }


        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Data
        {
            get
            {
                return data;
            }

            set
            {
                data = value;
            }
        }

        public int T_celular
        {
            get
            {
                return t_celular;
            }

            set
            {
                t_celular = value;
            }
        }

        public int T_residencial
        {
            get
            {
                return t_residencial;
            }

            set
            {
                t_residencial = value;
            }
        }

    }
}