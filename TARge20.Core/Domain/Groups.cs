using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TARge20.Core.Domain
{
   public class Groups
    {
        [Key]
        public Guid Id { get; set; }

        public string Name { get; set; }
        public string Type { get; set; }

        [ForeignKey("Group_Id")]
        public Guid Group_Id { get; set; }

        [ForeignKey("Children_Id")]
        public Guid Children_Id { get; set; }
        
        public string Employee_FirstName { get; set; }
        public string Employee_LastName { get; set; }
        [ForeignKey("Employee_Id")]
        public Guid Employee_Id { get; set; }



        [ForeignKey("Available_Spots")]

        public int Available_Spots { get; set; }

        public List<Employee> Employees;

        public List<Queue> Queues;

        public List<Children> Childrens;







    }
}
