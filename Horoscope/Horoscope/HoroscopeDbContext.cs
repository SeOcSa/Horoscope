using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Horoscope
{
    public class HoroscopeDbContext:DbContext
    {
        public HoroscopeDbContext(DbContextOptions<HoroscopeDbContext> option) : base(option)
        {

        }

        public DbSet<Student> StudentInfos { get; set; }
    }
}
