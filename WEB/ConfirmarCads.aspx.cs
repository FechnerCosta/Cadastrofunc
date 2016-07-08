using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WEB
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label2.Text = Request["nome"];
            Label3.Text = Request["cpf"];
            Label4.Text = Request["cargo"];
            Label5.Text = Request["salario"];
            Label6.Text = Request["dtadmin"];
        }

        protected void btnVoltar(object sender, EventArgs e)
        {
            Response.Redirect("CadastrarFunc.aspx");
        }

        protected void btn_home(object sender, EventArgs e)
        {
            Response.Redirect("Home.aspx");
        }
    }
}