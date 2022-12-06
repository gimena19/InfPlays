using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace AppMovil.Models
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
        public String FullName { get; set; }
        public String Age { get; set; }
        public DateTime Creation_Date { get; set; }
    }
}
    