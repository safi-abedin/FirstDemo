﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo.Infrastructure.BusinessObjects
{
    public class Course
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public double Fees { get; set; }

        public DateTime ClassStartDate { get; set; }

        internal async Task SetProperClassStartDate()
        {
            if (ClassStartDate.Subtract(DateTime.Now).TotalDays < 30)
                ClassStartDate = DateTime.Now.AddDays((30));
        }
    }
}
