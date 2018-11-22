using Microsoft.EntityFrameworkCore;
using Oracle.Net.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oracle.Net.Data
{
    public class OracleContext:DbContext
    {
        public OracleContext(DbContextOptions<OracleContext> options)
        : base(options)
        { }

        public DbSet<User> User { get; set; }

        public DbSet<Test> Test { get; set; }

        public DbSet<Score> Score { get; set; }

        public DbSet<Testlist> Testlist { get; set; }

        public DbSet<Question> Question { get; set; }

        public DbSet<Answer> Answer { get; set; }

        public DbSet<Comment> Comment { get; set; }

        public DbSet<Scenetest> Scenetest { get; set; }

        public DbSet<Upload> Upload { get; set; }

        public DbSet<News> News { get; set; }
    }
}
