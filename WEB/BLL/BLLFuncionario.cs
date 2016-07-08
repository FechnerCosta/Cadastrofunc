using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WEB.OBJETO;
using WEB.DAL;



namespace WEB.BLL
{
    public class BLLFuncionario
    {
        public void cadastrar(OBJFuncionario func)
        {
            DALFuncionario f = new DALFuncionario();
            f.cadastrar(func);
        }
        public List<OBJFuncionario> listafun()
        {
            DALFuncionario dalf = new DALFuncionario();
            return dalf.listafun();
        }
    }
}