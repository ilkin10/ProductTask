﻿using ProductTask.DataAccess.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductTask.DataAccess.Abstractions
{
    public interface ICategoryRepository : IOrderRepository<Category>
    {
    }
}
