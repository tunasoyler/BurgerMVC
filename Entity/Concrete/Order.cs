﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Concrete
{
    public class Order : BaseEntity
    {
        public ICollection<Menu> Menus { get; set; }
        public ICollection<Burger> Burgers { get; set; }
        public ICollection<Beverage> Beverages { get; set; }
        public ICollection<ExtraSauce> ExtraSauces { get; set; }
        public ICollection<ExtraSauce> ExtraSnacks { get; set; }
        public ICollection<Desert> Deserts { get; set; }
        public Coupon? Coupon { get; set; }
    }
}
