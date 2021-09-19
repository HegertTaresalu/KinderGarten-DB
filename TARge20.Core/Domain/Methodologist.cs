using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TARge20.Core.Domain
{
   public class Methodologist
    {
        public string First_Name { get; set; }
        
        public string Last_Name { get; set; }


        [ForeignKey("Worker_Id")]
        public Guid Worker_Id { get; set; }

        [ForeignKey("Occupation")]
        public string Occupation { get; set; }
        
    }
}
