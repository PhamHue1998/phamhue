using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using 携帯会社販売管理システム.Model.Entities.DB;

namespace 携帯会社販売管理システム.IService
{
    interface ISaleOfficeService
    {
        public IEnumerable<M_SalesOffice> GetSaleOffice();
    }
}
