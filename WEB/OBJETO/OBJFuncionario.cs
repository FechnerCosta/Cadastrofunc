using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WEB.OBJETO
{
    public class OBJFuncionario
    {
        private int id;
        private String cargo;
        private Decimal salario;
        private DateTime dtadmin;
        private String nome;
        private String cpf;

            public string Cargo
            {
                get
                {
                    return cargo;
                }

                set
                {
                    cargo = value;
                }
            }

            public decimal Salario
            {
                get
                {
                    return salario;
                }

                set
                {
                    salario = value;
                }
            }

            public DateTime Dtadmin
            {
                get
                {
                    return dtadmin;
                }

                set
                {
                    dtadmin = value;
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
    }
}