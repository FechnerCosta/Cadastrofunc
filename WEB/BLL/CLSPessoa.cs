using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB.BLL
{

    public class CLSPessoa
    {
        private int id;
        private String nome;
        private String cpf;

        public CLSPessoa()
        {
        }

        public CLSPessoa(int id, string nome, string cpf) {
            this.id = id;
            this.nome = nome;
            this.cpf = cpf;

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

        public string Cpf
        {
            get
            {
                return cpf;
            }

            set
            {
                cpf = value;
            }
        }
      
    }
}