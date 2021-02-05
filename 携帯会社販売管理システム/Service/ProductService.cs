using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 携帯会社販売管理システム.IService;
using 携帯会社販売管理システム.Model.Entities.DB;

namespace 携帯会社販売管理システム.Service
{
    class ProductService : IProductService
    {
        private InventoryManage db { get; }
        public ProductService()
        {
            db = new InventoryManage();
        }
        public bool AddPr(M_Product product)
        {
            if (db.M_Product.Any(x => x.PrID == product.PrID))
            {
                return false;
            }
            else
            {
                db.M_Product.Add(product);
                db.SaveChanges();
                return true;
            }
        }

        public bool DeletePr(string prID)
        {
            M_Product product = db.M_Product.SingleOrDefault(x => x.PrID == prID);
            if (product == null)
            {
                return false;
            }
            else
            {
                db.M_Product.Remove(product);
                db.SaveChanges();
                return true;
            }
        }

        public bool SearchPr(string prName, string prID)
        {
            var listPr = db.M_Product.Where(x => x.PrName.Contains(prName));
            if (listPr.Count() == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
            var listPr1 = db.M_Product.Where(x => x.PrID.Contains(prID));
            if (listPr1.Count() == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public IEnumerable<M_Product> GetProductList()
        {
            var lstPr = db.M_Product.AsQueryable();
            return lstPr;
        }

        public bool UpdatePr(M_Product product)
        {
            M_Product pr = db.M_Product.SingleOrDefault(x => x.PrID == product.PrID);
            if (pr == null)
            {
                return false;
            }
            else
            {
                pr.PrName = product.PrName;
                pr.PrCode = product.PrCode;
                pr.SOID = product.SOID;
                pr.PrTotal = product.PrTotal;
                pr.Mnumber = product.Mnumber;
                pr.Color = product.Color;
                pr.PrUnitPrice = product.PrUnitPrice;
                pr.Rdate = product.Rdate;
                pr.PDFlag = product.PDFlag;
                db.SaveChanges();
                return true;
            }
        }

        public bool checkPr(String idPr)
        {
            M_Product pr = db.M_Product.SingleOrDefault(x => x.PrID == idPr);
            if (pr == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}
