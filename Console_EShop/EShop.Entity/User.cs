using System;
using System.Collections.Generic;
using System.Text;

namespace EShop.Entity
{
    public class User
    {
        public string UserName { get; set; }

        public List<Order> UserOrder { get; private set; }

        public User()
        {
            UserOrder = new List<Order>();
        }

        public User(string userName)
        {
            UserName = userName;
        }
    }
}
