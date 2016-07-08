using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WEB.BLL;
using WEB.OBJETO;


namespace WEB
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        


            public void cadastrar_funcionario()
        {
            CLSFuncionario f = new CLSFuncionario();
            f.Nome = txtNome.Text;
            f.Cpf = txtCPF.Text;
            f.Cargo = txtCargo.Text;
            f.Salario = Convert.ToDecimal(txtsalario.Text);
            f.Dtadmin = Convert.ToDateTime(txtdtadmin.Text);

        }
   

        protected void Page_Load(object sender, EventArgs e)
        {

        }
        

        protected void btn_enviar(object sender, EventArgs e)
        {
            OBJFuncionario objf = new OBJFuncionario();
            CLSFuncionario clsf = new CLSFuncionario();
            BLLFuncionario bllf = new BLLFuncionario();

            objf.Nome = txtNome.Text;
            objf.Cpf = txtCPF.Text;
            objf.Cargo = txtCargo.Text;
            objf.Salario = Convert.ToDecimal(txtsalario.Text);
            objf.Dtadmin = Convert.ToDateTime(txtdtadmin.Text);
            bllf.cadastrar(objf);

            Response.Redirect("listafuncionario.aspx");
        }

        protected void btn_home(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}