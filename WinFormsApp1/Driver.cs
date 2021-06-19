using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    class Driver
    {
        private static Driver instance;

        private List<User> user;

        public List<User> GetUser()
        {
            return user;
        }

        private Driver()
        {
            user = new List<User>();
        }

        public static Driver GetInstance()
        {
            if (instance == null)
                instance = new Driver();

            return instance;
        }
    }
}
