using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 携帯会社販売管理システム.IService;
using 携帯会社販売管理システム.Model.Entities.DB;

namespace 携帯会社販売管理システム.Service
{
    class StockService : IStockService
    {
        private InventoryManage db { get; }
        public StockService()
        {
            db = new InventoryManage();
        }

        public IEnumerable<T_Stock> GetStockList()
        {
            var lstStock = db.T_Stock.AsQueryable();
            return lstStock;
        }

        public bool SearchSt(string prName)
        {
            var listPr = db.M_Product.Where(x => x.PrName.Contains(prName)).ToList();
            if (listPr.Count() == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool UpdateSt(T_Stock stock)
        {
            T_Stock st = db.T_Stock.SingleOrDefault(x => x.StockID == stock.StockID);
            if (st == null)
            {
                return false;
            }
            else
            {

                st.Squantity = stock.Squantity;
                db.SaveChanges();
                return true;
            }
        }
        public bool CheckStockID(int stID)
        {
            T_Stock st = db.T_Stock.SingleOrDefault(x => x.StockID == stID);
            if (st == null)
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
