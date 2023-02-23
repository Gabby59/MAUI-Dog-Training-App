using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PAW_PAW.Model
{

    // annotate the users class with the [Table] attribute, "Paw-Paw User" table name
  //  [Table("Paw-Paw Users")]
    public class User
    {
        //set the id as PK
     //   [PrimaryKey, AutoIncrement]
       // public int Id { get; set; }

        //set the username as unique value, max 250
        [MaxLength(250), Unique]
        public string Username { get; set; }

        [MaxLength(250)]
        public string Password { get; set; }    



    }
}
