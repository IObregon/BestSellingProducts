using BestSellingProducts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestSellingProducts.Core
{
    public interface IBestSellingProductsDataSource
    {
        List<GetTopTen_Result> GetTopTen();
        List<GetTopFiveEveryCategory_Result> GetTopFiveEveryCategory();
    }
}
