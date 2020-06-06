using BusinessLayer;
using DataAccesLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer
{
    public class UsersBL
    {
        public static Users GetUser(int IdUsers)
        {
            return UserDA.GetUser(IdUsers);
        }
        public static List<Users> ListAllUser()
        {
            {
                return UserDA.ListAllUser();
            }

        }
        public static Boolean InsertUsers(Users users)
        {
            var g = Guid.NewGuid();

            users.UserCode = g.ToString();
                return UserDA.InsertUsers(users);
            

        }
    }
}
