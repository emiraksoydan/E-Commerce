using Core.EfCore;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class CategorieDal : EfEntityRepository<Categories,DbConnection>, ICategoryDal
    {
        public CategorieDal(DbConnection context) : base(context)
        {
            Console.WriteLine("buradayım iilk");
        }
    }
}
