﻿using AI.nRepo.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AI.nRepo.CouchDB
{
    public class CouchDbConfiguration : IRepositoryConfiguration
    {
        public void Start()
        {
            
        }

        public IDataAccessor<T> Create<T>()
        {
            return new CouchDbDataAccessor<T>();
        }
    }
}
