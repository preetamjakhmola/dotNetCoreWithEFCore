using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace dotNetTutorial.DbModels
{
    public partial class StudentManagementContextRepository: StudentManagementContext
    {

        //public StudentManagementContextRepository(DbContextOptions<StudentManagementContextRepository> options) 
        //{
        //}
        public StudentManagementContextRepository(DbContextOptions<StudentManagementContextRepository> options)
            : base(options)
        {
        }
        //public StudentManagementContextReponsitory()
        //{
        //}


        //        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //        {
        //            if (!optionsBuilder.IsConfigured)
        //            {
        ////#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
        //                optionsBuilder.UseSqlServer("Server=SEW-APAC-037\\MSSQLSERVERPC; Database= StudentManagement; Trusted_Connection=True;");
        //            }
        //        }

    }
}
