﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class ComplaintSuggestion : BaseEntity
    {
        public string? Title { get; set; }
        public string? Comment { get; set; }     
        public string? Email { get; set; }     
        public string? Phone { get; set; } 
    }
}
