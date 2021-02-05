using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 携帯会社販売管理システム.IService;
using 携帯会社販売管理システム.Model.Entities.DB;

namespace 携帯会社販売管理システム.Service
{
    class SaleOfficeService : ISaleOfficeService
    {
        private InventoryManage manage { get; }
        public SaleOfficeService()
        {
            manage = new InventoryManage();
        }
        public IEnumerable<M_SalesOffice> GetSaleOffice()
        {
            var saleOfficeList = manage.M_SalesOffice.AsQueryable();
            return saleOfficeList;
           
        }
    }
}
