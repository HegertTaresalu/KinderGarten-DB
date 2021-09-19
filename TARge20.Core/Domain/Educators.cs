using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TARge20.Core.Domain
{
   public class Educators
    {
        [Key]
        public Guid Id { get; set; }
        
        public string First_Name { get; set; }
        public string Last_Name { get; set; }

        [ForeignKey("Employee_Id")]
        public Guid Employee_Id { get; set; }

        [ForeignKey("Occupation")]
        public string Occupation { get; set; }
    }
}
