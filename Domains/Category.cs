﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domains
{
    public class Category: BaseEntity
    {
       
        public string Name { get; set; }
      
        public string Description { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
