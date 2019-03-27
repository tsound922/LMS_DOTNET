﻿using Data.Database;
using Data.Repositories.interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model.Model;

namespace Data.Repositories
{
    public abstract class GenericRepository<T> : IGenericRepository<T> where T : class
    }
}