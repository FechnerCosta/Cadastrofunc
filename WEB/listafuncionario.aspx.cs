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
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Response.Write("<table>");
            BLLFuncionario bllf = new BLLFuncionario();
            List<OBJFuncionario> listaf = new List<OBJFuncionario>();
            listaf = bllf.listafun();
            for (int i = 0; i < listaf.Count; i++)
            {
                Response.Write("<tr>");
                Response.Write("<td>" + listaf[i].Id + "</td>");
                Response.Write("<td>" + listaf[i].Nome + "</td>");
                Response.Write("<td>" + listaf[i].Cargo + "</td>");
                Response.Write("<td>" + listaf[i].Cpf + "</td>");
                Response.Write("<td>" + listaf[i].Salario + "</td>");
                Response.Write("<td>" + listaf[i].Dtadmin + "</td>");
                Response.Write("</tr>");
            }

            Response.Write("</table>");

        }
    }
}