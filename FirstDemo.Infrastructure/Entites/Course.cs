﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDemo.Infrastructure.Entites
{
    public class Course
    {
        public Guid Id { get; set; }

         public string Title { get; set; }

        public double Fees { get; set; }
        
        public DateTime ClassStartDate { get; set; }
    }
}
