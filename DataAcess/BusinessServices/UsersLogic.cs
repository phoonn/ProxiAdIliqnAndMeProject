//using Microsoft.AspNet.Identity;
//using Microsoft.AspNet.Identity.EntityFramework;
//using Models;
//using Repositories;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Security.Claims;
//using System.Text;
//using System.Threading.Tasks;

//namespace BusinessServices
//{
//    public class UsersLogic
//    {
//        WebStoreContext context;

//        public User FindUserAsync(string email, string password)
//        {
//            using (context = new WebStoreContext())
//            {
//                using (UserManager<User> usermanager = new UserManager<User>(new UserStore<User>(context)))
//                {
//                    return usermanager.Find(email, password);
//                }
//            }
//        }

//        public ClaimsIdentity CreateIdentity(User user , string type)
//        {
//            using (context = new WebStoreContext())
//            {
//                using (UserManager<User> usermanager = new UserManager<User>(new UserStore<User>(context)))
//                {
//                    return usermanager.CreateIdentity(user, type);
//                }
//            }
//        }
//    }
//}
