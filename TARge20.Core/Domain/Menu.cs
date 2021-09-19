using System;
using System.Collections.Generic;
using System.Text;

namespace TARge20.Core.Domain
{
    public class Menu
    {

        public Guid Id { get; set; }

        public DayOfWeek WeekDay { get; set; }

        public string Breakfast { get; set; }

        public string Lunch { get; set; }

    }
}
