using BestSellingProducts.Models;
using System.Collections.Generic;

namespace BestSellingProducts.Core
{
    public interface IBestSellingProductsDataSource
    {
        List<GetTopTen_Result> GetTopTen();
        Dictionary<string, List<GetTopFiveEveryCategory_Result>> GetTopFiveEveryCategory();
    }
}
