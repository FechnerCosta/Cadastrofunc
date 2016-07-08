using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace WEB.BLL
{

    public class CLSFuncionario : CLSPessoa
    {
        private String cargo;
        private Decimal salario;
        private DateTime dtadmin;

        public CLSFuncionario()
        {

        }

        public CLSFuncionario(string cargo, decimal salario, DateTime dtadmin)
        {
            this.cargo = cargo;
            this.salario = salario;
            this.dtadmin = dtadmin;
        }

        public CLSFuncionario(int id, string nome, string cpf) : base(id, nome, cpf)
        {
        }

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
    }
}