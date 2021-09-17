using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TARge20.Core.Domain
{
    public class KinderGarden
    {


        [Key]
        public Guid Id { get; set; }

        public string Employee_First_Name { get; set; }
        public string Employee_Last_Name { get; set; }

        public Guid Employee_Id { get; set; }

        public string Parent_First_Name { get; set; }

        public string Parent_Last_Name { get; set; }


    }
}
