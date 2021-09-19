using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TARge20.Core.Domain
{
   public class Queue

    {   [ForeignKey("Available_spots")]
        public int Available_spots { get; set; }
        [ForeignKey("Child_Id")]
        public Guid Child_Id { get; set; }

        [ForeignKey("Queue_spot")]
        public int Queue_spot { get; set; }

        public List<Children> Childrens;

    }
}
