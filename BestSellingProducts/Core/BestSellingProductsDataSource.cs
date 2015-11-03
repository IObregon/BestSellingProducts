using BestSellingProducts.Models;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;

namespace BestSellingProducts.Core
{
    public class BestSellingProductsDataSource : IBestSellingProductsDataSource
    {
        public ExamDBEntities _context;

        public BestSellingProductsDataSource(ExamDBEntities context)
        {
            this._context = context;
        }

        public List<GetTopTen_Result> GetTopTen()
        {
            ObjectResult<GetTopTen_Result> resultList = _context.GetTopTen();


            var list = new List<GetTopTen_Result>();

            list = (from a in resultList select a).ToList<GetTopTen_Result>();

            return list;
        }

        public Dictionary<string, List<GetTopFiveEveryCategory_Result>> GetTopFiveEveryCategory()
        {
            ObjectResult<GetTopFiveEveryCategory_Result> resultList = _context.GetTopFiveEveryCategory();

            var list = new List<GetTopFiveEveryCategory_Result>();

            list = (from a in resultList select a).ToList<GetTopFiveEveryCategory_Result>();

            var map = list.GroupBy(x => x.CategoryName).ToDictionary(x => x.Key, x => x.ToList());

            return map;
        }
    }
}