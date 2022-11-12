using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Finance.Models
{
    public class Cost
    {
        [PrimaryKey, AutoIncrement]

        public int Id { get; set; }
        public string Type { get; set; }
        public string Kategoriya { get; set; }
        public string Price { get; set; }
        public DateTime Date { get; set; }
        public string Descripion { get; set; }
    }
}
