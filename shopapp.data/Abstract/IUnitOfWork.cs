﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace shopapp.data.Abstract
{
    public interface IUnitOfWork:IDisposable
    {
        IProductRepository Products { get; }
        ICartRepository Carts { get; }
        ICategoryRepository Categories { get; }
        IOrderRepository Orders { get; }
        void Save();
        Task<int> SaveAsync();
    }
}
