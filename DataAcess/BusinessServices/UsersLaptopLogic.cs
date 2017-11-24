﻿using Interfaces;
using Models;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessServices
{
    public class UsersLaptopLogic : IUsersLaptopLogic<Laptops>
    {
        IUnitOfWork Unit;
        IRepository<Laptops> laptoprepo;
        IRepository<UsersLaptops> userslaptoprepo;

        public UsersLaptopLogic(IUnitOfWork Unit, IRepository<Laptops> laptoprepo, IRepository<UsersLaptops> userslaptoprepo)
        {
            this.Unit = Unit;
            this.laptoprepo = laptoprepo;
            this.userslaptoprepo = userslaptoprepo;
        }

        public IEnumerable<Laptops> GetAllUserLaptops(string userid)
        {
            List<int> laptopids = userslaptoprepo.Get(l => l.UserID == userid,null,String.Empty,0).Select(l=>l.LaptopID).ToList();
            
            return laptoprepo.Get(l=> laptopids.Contains(l.LaptopID),null,String.Empty,0);
        }
    }
}