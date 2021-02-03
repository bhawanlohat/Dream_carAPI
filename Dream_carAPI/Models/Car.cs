using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Dream_carAPI.Models
{
    public class Car
    {
        public int Id { get; set; }// primary key in int datatype
        [Required]//cannot be null
        public string Company_Name { get; set; }//value add in string type data
        [Required]//cannot be null
        public string Model_Name { get; set; }//value add in string type data
        [Required]//cannot be null
        public string Model_Year { get; set; }//value add in string type data
        public string Fuel_type { get; set; }//value add in string type data
        [Required]//cannot be null
        public string Transmission { get; set; }//value add in string type data

    }
}
