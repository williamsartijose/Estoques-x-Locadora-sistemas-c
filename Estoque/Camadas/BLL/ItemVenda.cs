using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estoque.Camadas.BLL
{
    public class ItemVenda
    {
        public List<Model.ItemVenda> SelectById(int idVenda)
        {
            DAL.ItemVenda dalItemVendas = new DAL.ItemVenda();
            return dalItemVendas.SelectById(idVenda); 
        }

        public List<Model.ItemVenda> Select()
        {
            DAL.ItemVenda dalItemVendas = new DAL.ItemVenda();
            return dalItemVendas.Select();
        }

        public void Insert(Model.ItemVenda itemVenda)
        {
            DAL.ItemVenda dalItemVendas = new DAL.ItemVenda();
            dalItemVendas.Insert(itemVenda);
        }

        public void Update(Model.ItemVenda itemVenda)
        {
            DAL.ItemVenda dalItemVendas = new DAL.ItemVenda();
            dalItemVendas.Update(itemVenda);
        }

        public void Delete(Model.ItemVenda itemVenda)
        {
            DAL.ItemVenda dalItemVendas = new DAL.ItemVenda();
            dalItemVendas.Delete(itemVenda);
        }
    }
}
