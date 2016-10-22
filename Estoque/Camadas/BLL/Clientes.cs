using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Camadas.BLL
{
    public class Clientes{
    
        public List<Model.Clientes> Select() {
            DAL.Clientes dalCli = new DAL.Clientes();
            return dalCli.Select(); 
        }


        public void Insert (Model.Clientes cliente){
            DAL.Clientes dalCli = new DAL.Clientes();
            dalCli.Insert(cliente);
        }

        public void Update(Model.Clientes cliente)
        {
            DAL.Clientes dalCli = new DAL.Clientes();
            dalCli.Update(cliente);
        }

        public void Delete(Model.Clientes cliente)
        {
            DAL.Clientes dalCli = new DAL.Clientes();
            dalCli.Delete(cliente); 
        }
    }
}
