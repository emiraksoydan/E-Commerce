using Business.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IStockService
    {
        IResult AddStock(Stock stock);
        IResult UpdateStock(Stock stock);
        IResult DeleteStock(Stock stock);

        IDataResult<ICollection<Stock>> GetAllStock();
        IDataResult<Stock> GetStock(Guid id);
    }
}
