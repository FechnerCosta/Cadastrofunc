using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;
using WEB.OBJETO;

namespace WEB.DAL
{
    public class DALFuncionario
    {
        //Connection
        SqlConnection cn = new SqlConnection();
        SqlCommand cmd = new SqlCommand();

        private void conectar()
        {
            cn.ConnectionString = ConfigurationManager.ConnectionStrings["conexaofunc"].ToString();
            cn.Open();
        }
        private void fechar()
        {
            cn.Close();
        }

        public void cadastrar(OBJFuncionario obj)
        {
            conectar();

            cmd.Parameters.Add(new SqlParameter("@nome", obj.Nome));
            cmd.Parameters.Add(new SqlParameter("@cpf", obj.Cpf));
            cmd.Parameters.Add(new SqlParameter("@cargo", obj.Cargo));
            cmd.Parameters.Add(new SqlParameter("@sal", obj.Salario));
            cmd.Parameters.Add(new SqlParameter("@dtadmin", obj.Dtadmin));
            cmd.CommandText = "STR_TBLFunc_IN";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Connection = cn;
            cmd.ExecuteNonQuery();
            fechar();

        }
        public void consultar()
        {

        }
        public List<OBJFuncionario> listafun()
            {

                List<OBJFuncionario> listafun = new List<OBJFuncionario>();
                conectar();
                cmd.Connection = cn;
                cmd.CommandText = "STR_seleciona_func";
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader rd = cmd.ExecuteReader();
               
                while (rd.Read()) {
                    OBJFuncionario objf = new OBJFuncionario();
       
                    objf.Nome = Convert.ToString(rd["nome"]);
                    objf.Cpf = Convert.ToString(rd["cpf"]);
                    objf.Cargo = Convert.ToString(rd["cargo"]);
                    objf.Salario = Convert.ToDecimal(rd["salario"]);
                    objf.Dtadmin = Convert.ToDateTime(rd["dtadmin"]);
                    listafun.Add(objf);
                }
            fechar();


                return listafun;
        }   
   }
}