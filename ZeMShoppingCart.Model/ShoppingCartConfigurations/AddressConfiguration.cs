﻿using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZeMShoppingCart.Model
{
   public class AddressConfiguration : EntityTypeConfiguration<Address>
    {
       public AddressConfiguration()
       {
           ToTable("Address");
           HasKey(a => a.Id);
       }
    }
}
