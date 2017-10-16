using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WepApi.Model.Entities;

namespace WepApi.Models
{
    public class WepApiContext : DbContext
    {
        public WepApiContext (DbContextOptions<WepApiContext> options)
            : base(options)
        {
        }

        public DbSet<TodoItem> TodoItem { get; set; }
    }
}
