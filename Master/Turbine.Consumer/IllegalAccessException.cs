﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Turbine.Consumer
{
    public class IllegalAccessException : Exception
    {
        public IllegalAccessException(string msg)
            : base(msg)
        {
        }
    }
}
