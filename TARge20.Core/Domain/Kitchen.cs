using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TARge20.Core.Domain
{
    public class Kitchen
    {

        [Key]
        public Guid Id { get; set; }

        public Guid Worker_Id { get; set; }

        public List<Menu> Menus;
    }
}
