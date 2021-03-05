using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace dotNetTutorial.DbModels
{
    public partial class StudentManagementContext : DbContext
    {
        //public StudentManagementContext()
        //{
        //}

        public StudentManagementContext(DbContextOptions<StudentManagementContextRepository> options)
            : base(options)
        {
        }

        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<EmpMaster> EmpMaster { get; set; }
        public virtual DbSet<MembershipData> MembershipData { get; set; }
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Sheetimp> Sheetimp { get; set; }
        public virtual DbSet<StudentMaster> StudentMaster { get; set; }
        public virtual DbSet<Test> Test { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
               // optionsBuilder.UseSqlServer("Server=SEW-APAC-037\\MSSQLS ERVERPC; Database= StudentManagement; Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmpMaster>(entity =>
            {
                entity.Property(e => e.City).HasMaxLength(30);

                entity.Property(e => e.Email).HasMaxLength(150);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Phone)
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MembershipData>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("membership_data");

                entity.Property(e => e.AppType).HasColumnName("app_type");

                entity.Property(e => e.ConstitutionTypeOfFirm).HasColumnName("Constitution_Type_of_Firm");

                entity.Property(e => e.CorrespondenceAddress).HasColumnName("Correspondence_Address");

                entity.Property(e => e.CustomJurisdiction).HasColumnName("custom_jurisdiction");

                entity.Property(e => e.DateOfCommencementOfProduction).HasColumnName("Date_of_commencement_of_production");

                entity.Property(e => e.EmailId3).HasColumnName("Email_ID3");

                entity.Property(e => e.ExportCountriesMasterId).HasColumnName("export_countries_MASTER_ID");

                entity.Property(e => e.Gstinno).HasColumnName("GSTINNo");

                entity.Property(e => e.IecNumber).HasColumnName("iec_number");

                entity.Property(e => e.LoaLopDate).HasColumnName("LOA_LOP_Date");

                entity.Property(e => e.LoaLopNo).HasColumnName("LOA_LOP_No");

                entity.Property(e => e.ManagingDirectorDirector).HasColumnName("Managing_Director_Director");

                entity.Property(e => e.MemberRegisterYear).HasColumnName("Member_Register_year");

                entity.Property(e => e.MobileNo1).HasColumnName("Mobile_No1");

                entity.Property(e => e.MobileNo2).HasColumnName("Mobile_No2");

                entity.Property(e => e.MobileNo3).HasColumnName("Mobile_No3");

                entity.Property(e => e.Msub202021).HasColumnName("MSub_202021");

                entity.Property(e => e.PServiceCategoryMasterId).HasColumnName("p_service_category_MASTER_ID");

                entity.Property(e => e.ProductDescription).HasColumnName("product_description");

                entity.Property(e => e.Rcmcno).HasColumnName("RCMCNo");

                entity.Property(e => e.ReceiptDate202021).HasColumnName("Receipt_date_202021");

                entity.Property(e => e.SezServiceSectorMasterId).HasColumnName("sez_service_sector_MASTER_ID");

                entity.Property(e => e.Sno)
                    .HasColumnName("SNo")
                    .HasMaxLength(255);

                entity.Property(e => e.TelNo1).HasColumnName("Tel_No1");

                entity.Property(e => e.TelNo2).HasColumnName("Tel_No2");

                entity.Property(e => e.TelNo3).HasColumnName("Tel_No3");

                entity.Property(e => e.UnitCategory).HasColumnName("unit_category");

                entity.Property(e => e.UnitFactoryAddress).HasColumnName("unit_factory_address");

                entity.Property(e => e.UnitName).HasColumnName("unit_name");

                entity.Property(e => e.UnitState).HasColumnName("unit_state");

                entity.Property(e => e.UnitZone).HasColumnName("unit_zone");

                entity.Property(e => e.ValidityOfLoaLop).HasColumnName("Validity_of_LOA_LOP");
            });

            modelBuilder.Entity<Products>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CustomerId)
                    .IsRequired()
                    .HasColumnName("customerId")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ProductId).HasColumnName("productId");

                entity.Property(e => e.ProductName)
                    .IsRequired()
                    .HasColumnName("productName")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Sheetimp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Sheetimp$");

                entity.Property(e => e.AppType).HasColumnName("app_type");

                entity.Property(e => e.ConstitutionTypeOfFirm).HasColumnName("Constitution_Type_of_Firm");

                entity.Property(e => e.CorrespondenceAddress).HasColumnName("Correspondence_Address");

                entity.Property(e => e.CustomJurisdiction).HasColumnName("custom_jurisdiction");

                entity.Property(e => e.DateOfCommencementOfProduction).HasColumnName("Date_of_commencement_of_production");

                entity.Property(e => e.EmailId3).HasColumnName("Email_ID3");

                entity.Property(e => e.ExportCountriesMasterId).HasColumnName("export_countries_MASTER_ID");

                entity.Property(e => e.Gstinno).HasColumnName("GSTINNo");

                entity.Property(e => e.IecNumber).HasColumnName("iec_number");

                entity.Property(e => e.LoaLopDate).HasColumnName("LOA_LOP_Date");

                entity.Property(e => e.LoaLopNo).HasColumnName("LOA_LOP_No");

                entity.Property(e => e.ManagingDirectorDirector).HasColumnName("Managing_Director_Director");

                entity.Property(e => e.MemberRegisterYear).HasColumnName("Member_Register_year");

                entity.Property(e => e.MobileNo1).HasColumnName("Mobile_No1");

                entity.Property(e => e.MobileNo2).HasColumnName("Mobile_No2");

                entity.Property(e => e.MobileNo3).HasColumnName("Mobile_No3");

                entity.Property(e => e.Msub202021).HasColumnName("MSub_202021");

                entity.Property(e => e.PServiceCategoryMasterId).HasColumnName("p_service_category_MASTER_ID");

                entity.Property(e => e.ProductDescription).HasColumnName("product_description");

                entity.Property(e => e.Rcmcno).HasColumnName("RCMCNo");

                entity.Property(e => e.ReceiptDate202021).HasColumnName("Receipt_date_202021");

                entity.Property(e => e.SezServiceSectorMasterId).HasColumnName("sez_service_sector_MASTER_ID");

                entity.Property(e => e.Sno).HasColumnName("SNo");

                entity.Property(e => e.TelNo1).HasColumnName("Tel_No1");

                entity.Property(e => e.TelNo2).HasColumnName("Tel_No2");

                entity.Property(e => e.TelNo3).HasColumnName("Tel_No3");

                entity.Property(e => e.UnitCategory).HasColumnName("unit_category");

                entity.Property(e => e.UnitFactoryAddress).HasColumnName("unit_factory_address");

                entity.Property(e => e.UnitName).HasColumnName("unit_name");

                entity.Property(e => e.UnitState).HasColumnName("unit_state");

                entity.Property(e => e.UnitZone).HasColumnName("unit_zone");

                entity.Property(e => e.ValidityOfLoaLop).HasColumnName("Validity_of_LOA_LOP");
            });

            modelBuilder.Entity<StudentMaster>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Batch)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(150);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Test>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.C)
                    .HasColumnName("c")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.D)
                    .HasColumnName("d")
                    .HasColumnType("date");

                entity.Property(e => e.Id).HasColumnName("id");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
