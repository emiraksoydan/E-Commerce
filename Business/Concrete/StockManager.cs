using Business.Abstract;
using Business.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class StockManager : IStockService
    {
        IStockDal _stockDal;

        public StockManager(IStockDal stockDal)
        {
            _stockDal = stockDal;
        }

        public IResult AddStock(Stock stock)
        {
            _stockDal.Add(stock);
            return new SuccessResult();

        }

        public IResult DeleteStock(Stock stock)
        {
            _stockDal.Delete(stock);
            return new SuccessResult();
        }

        public IDataResult<ICollection<Stock>> GetAllStock()
        {
            return new SuccessDataResult<ICollection<Stock>>(_stockDal.GetAll());
        }

        public IDataResult<Stock> GetStock(Guid id)
        {
            return new SuccessDataResult<Stock>(_stockDal.Get(st=>st.Id == id));  
        }

        public IResult UpdateStock(Stock stock)
        {
            _stockDal.Update(stock);
            return new SuccessResult();

        }
    }
}
