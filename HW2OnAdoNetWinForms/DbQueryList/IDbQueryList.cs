using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2OnAdoNetWinForms.DbQueryList
{
    public interface IDbQueryList
    {
        string InitTypes();
        string InitBuyers();
        string InitManagers();
        string InitProducts();
        string InitSales();
        string ShowProducts();
        string ShowTypes();
        string ShowManagers();
        string MaxSalesProducts();
        string MinSalesProducts();
        string MaxPriceProducts();
        string MinPriceProducts();
        string ShowProductsByType();
        string ShowSalesByManager();
        string ShowSalesByBuyer();
        string ShowRecentSale();
        string ShowCountProductsType();
    }
}
