﻿using Core.Utilities.Results.Abstracts;
using Core.Utilities.Results.Concretes;
using Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concretes
{
    public class Cosecant : Operation
    {
        public Cosecant(double degree) : base(degree) // number2 == degree (true)
        {
            _result = 1/Math.Sin(degree);
        }

        public override IDataResult<double> Process()
        {
            return new SuccessDataResult<double>(_result);
        }
    }
}
