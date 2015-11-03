﻿using BestSellingProducts.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Web;

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

        public List<GetTopFiveEveryCategory_Result> GetTopFiveEveryCategory()
        {
            ObjectResult<GetTopFiveEveryCategory_Result> resultList = _context.GetTopFiveEveryCategory();

            var list = new List<GetTopFiveEveryCategory_Result>();

            list = (from a in resultList select a).ToList<GetTopFiveEveryCategory_Result>();

            return list;
        }
    }
}