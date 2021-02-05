using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 携帯会社販売管理システム.Model.Entities.DB;

namespace 携帯会社販売管理システム.IService
{
    interface IStockService
    {
        public IEnumerable<T_Stock> GetStockList();
        public bool UpdateSt(T_Stock stock);
        public bool SearchSt(string prName);
    }
}
