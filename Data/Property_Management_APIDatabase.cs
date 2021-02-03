using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Property_Management_API.Models;

namespace Property_Management_API.Data
{
    public class Property_Management_APIDatabase : DbContext
    {
        public Property_Management_APIDatabase (DbContextOptions<Property_Management_APIDatabase> options)
            : base(options)
        {
        }

        public DbSet<Property_Management_API.Models.Property> Property { get; set; }
    }
}
