﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFrameworkConsole.Entities
{
    public class EFContext:DbContext
    {
        public EFContext():base("AnimalsConnection")
        {

        }

        public DbSet<Animal> Animals { get; set; }
    }
}
