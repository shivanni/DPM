using DPM_Testing.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DPM_Testing.DAL
{
    public class DPMDal:DbContext
    {
        public DPMDal(DbContextOptions<DPMDal> options) : base(options)
        {

        }

        public DbSet<AddRuleModel> AddRuleModels { get; set; }

        public DbSet<compressuredetails> compressuredetails { get; set; }

        public DbSet<compressurewithclassification> compressureWithClassifications { get; set; }

        public DbSet<ClassificationMaster> classiMaster { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AddRuleModel>().ToTable("addrulemodel");
            modelBuilder.Entity<compressuredetails>().ToTable("compressuredetails");
            modelBuilder.Entity<compressurewithclassification>().ToTable("compressurewithclassification");

            modelBuilder.Entity<ClassificationMaster>().ToTable("classificationMaster");
        }

    }
}
