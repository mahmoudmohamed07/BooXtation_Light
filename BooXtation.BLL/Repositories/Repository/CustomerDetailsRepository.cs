﻿using BookXtation.DAL.Models;
using BookXtation.DAL.Models.Data;
using BooXtation.BLL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BooXtation.BLL.Repositories.Repository
{
    public class CustomerDetailsRepository : GenericReposiory<CustomerDetails>, ICustomerDetailsRepository
    {
        public CustomerDetailsRepository(BooXtationContext dbcontext) : base(dbcontext)
        {
        }

        
    }
}