using QuanLyThueXe.Daos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLyThueXe.Models
{
    public sealed class Singleton
    {
        public static Singleton Instance { get; } = new Singleton();
        public List<user> listUser { get; }
        private Singleton() { }
        public void Init()
        {
            UserDao userDao = new UserDao();
        }
    }
}