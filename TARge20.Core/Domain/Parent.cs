using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TARge20.Core.Domain
{
    public class Parent
    {
        public string First_Name { get; set; }
        public string Last_Name { get; set; }

        [ForeignKey("ParentId")]
        public Guid ParentId { get; set; }

        public List<KinderGarden> KinderGardens;

    }
}
