﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomat.Interfaces
{
    public interface IRepo<T>
    {
        T Retrieve(Guid id, List<T> list);
    }
}
