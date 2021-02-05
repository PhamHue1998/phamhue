using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 携帯会社販売管理システム.Model.Entities.DB;

namespace 携帯会社販売管理システム.IService
{
    interface IProductService
    {
        public IEnumerable<M_Product> GetProductList();
        public bool AddPr(M_Product product);
        public bool UpdatePr(M_Product product);
        public bool DeletePr(string prID);
        public bool SearchPr(string prName,string prID);
    }
}
