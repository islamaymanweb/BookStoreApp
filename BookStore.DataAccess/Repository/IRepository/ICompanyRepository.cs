﻿using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.DataAccess.Repository.IRepsitory
{
    public interface ICompanyRepository :IRepsitory<Company>
    {
        void Update(Company company);
    }
}
