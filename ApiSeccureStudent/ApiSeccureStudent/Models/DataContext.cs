﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ApiSeccureStudent.Models
{
    public class DataContext:DbContext
    {
        public DataContext() : base("DefaultConnection")
        { 
        }

        public System.Data.Entity.DbSet<ApiSeccureStudent.Models.Student> Students { get; set; }
    }
}