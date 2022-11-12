﻿using System;
using System.Collections.Generic;
using System.Text;
using SQLite; 

namespace Finance.Models
{
    public class User
    {
        [PrimaryKey, AutoIncrement]

        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string EMail { get; set; }
    }
}
