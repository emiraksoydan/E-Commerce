﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Results
{
    public class SuccessResult : Result
    {
        public SuccessResult(string message) : base(message, true)
        {
        }
        public SuccessResult() : base(true)
        {
        }

    }
}
