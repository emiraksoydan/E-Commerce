using Business.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Business
{
    public class BusinessClass
    {
        public static IResult ControlResult(params IResult[] results )
        {
            foreach (IResult result in results) {
                if (!result.Success) { 
                    return result;
                }
             
            }
            return null;
        }
    }
}
