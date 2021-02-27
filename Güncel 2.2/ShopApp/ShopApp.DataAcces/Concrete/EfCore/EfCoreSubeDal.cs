using ShopApp.DataAcces.Abstract;
using System;
using System.Collections.Generic;
using System.Text;
using ShopApp.DataAccess.Concrete.EfCore;
using ShopApp.Entities;

namespace ShopApp.DataAcces.Concrete.EfCore
{
    public class EfCoreSubeDal: EfCoreGenericRepository<Sube, ShopContext>, ISubeDal
    {
    }
}
