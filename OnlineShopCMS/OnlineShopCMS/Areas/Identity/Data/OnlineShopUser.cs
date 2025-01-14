﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace OnlineShopCMS.Areas.Identity.Data
{
    public class OnlineShopUser : IdentityUser
    {
        public string Name { get; set; }                //名稱
        public DateTime DOB { get; set; }               //生日
        public GenderType Gender { get; set; }          //性別
        public DateTime RegistrationDate { get; set; }  //註冊日期
    }

    public enum GenderType
    {
        Male, Female, Unknown
    }
}