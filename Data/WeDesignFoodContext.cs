using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WeDesignFood.Models
{
    public class WeDesignFoodContext : DbContext
    {
        public WeDesignFoodContext (DbContextOptions<WeDesignFoodContext> options)
            : base(options)
        {
        }

        public DbSet<Recipe> Recipe { get; set; }
    }
}
