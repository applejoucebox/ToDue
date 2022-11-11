﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDue.Models
{
    public class Task
    {
        public string TaskName { get; set; }
        public string DueDate { get; set; }
        public string Priority { get; set; }
        public string Subject { get; set; }
        public string Summary { get; set; }
        public string XDetails { get; set; }
    }
}
