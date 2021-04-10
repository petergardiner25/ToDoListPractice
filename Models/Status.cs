﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToDoListPractice.Models
{
    public class Status
    {
        [Key]
        public string StatusId { get; set; }
        public string Name { get; set; }
    }
}
