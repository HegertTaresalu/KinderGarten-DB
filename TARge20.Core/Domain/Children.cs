using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TARge20.Core.Domain
{
    public class Children
    {
        [Key]
        public Guid Id { get; set; }

        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public Guid Child_Id { get; set; }

        [ForeignKey("Parent_Id")]
        public Guid Parent_Id { get; set; }

        public string Current_Group { get; set; }


        [ForeignKey("Current_Group_ID")]
        public Guid Current_Group_Id { get; set; }
        public string Former_Group { get; set; }
    
        public Guid Former_Group_Id { get; set; }

        public List<Parent> Parents;
    }
}
