﻿using Core.EfCore;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class StockDal : EfEntityRepository<Stock,DbConnection>,IStockDal
    {
        public StockDal(DbConnection context) : base(context)
        {
        }
    }
}
