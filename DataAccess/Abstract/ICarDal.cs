﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    // Car ile ilgili veritabanında yapılacak işlemleri içeren interface
    public interface ICarDal : IEntityRepository<Car>
    {

    }
}
