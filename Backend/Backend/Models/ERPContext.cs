using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Backend.Models
{
    public partial class ERPContext : DbContext
    {
        public virtual DbSet<AccCategory> AccCategory { get; set; }
        public virtual DbSet<AccGroup> AccGroup { get; set; }
        public virtual DbSet<AccGroupCategory> AccGroupCategory { get; set; }
        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<AccType> AccType { get; set; }
        public virtual DbSet<AgreementType> AgreementType { get; set; }
        public virtual DbSet<Brand> Brand { get; set; }
        public virtual DbSet<CustomerDetails> CustomerDetails { get; set; }
        public virtual DbSet<Invoice> Invoice { get; set; }
        public virtual DbSet<Month> Month { get; set; }
        public virtual DbSet<PaymentMode> PaymentMode { get; set; }
        public virtual DbSet<PaymentTerms> PaymentTerms { get; set; }
        public virtual DbSet<PaymentType> PaymentType { get; set; }
        public virtual DbSet<ReceivedPayments> ReceivedPayments { get; set; }
        public virtual DbSet<Rent> Rent { get; set; }
        public virtual DbSet<Shop> Shop { get; set; }
        public virtual DbSet<ShopType> ShopType { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<UserType> UserType { get; set; }
        public virtual DbSet<VendorDetails> VendorDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer(@"Server=AS-EFT-HASHAM\SQLEXPRESS;Database=ERP;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AccCategory>(entity =>
            {
                entity.ToTable("ACC_CATEGORY");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountTypeId).HasColumnName("ACCOUNT_TYPE_ID");

                entity.Property(e => e.ManualCode)
                    .HasColumnName("MANUAL_CODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Priority)
                    .HasColumnName("PRIORITY")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AccGroup>(entity =>
            {
                entity.ToTable("ACC_GROUP");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountTypeId).HasColumnName("ACCOUNT_TYPE_ID");

                entity.Property(e => e.GroupCategoryId).HasColumnName("GROUP_CATEGORY_ID");

                entity.Property(e => e.ManualCode)
                    .HasColumnName("MANUAL_CODE")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Priority)
                    .HasColumnName("PRIORITY")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AccGroupCategory>(entity =>
            {
                entity.ToTable("ACC_GROUP_CATEGORY");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("ACCOUNT");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountCategoryId).HasColumnName("ACCOUNT_CATEGORY_ID");

                entity.Property(e => e.AccountNumber)
                    .IsRequired()
                    .HasColumnName("ACCOUNT_NUMBER")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.AccountTypeId).HasColumnName("ACCOUNT_TYPE_ID");

                entity.Property(e => e.BalanceLimit).HasColumnName("BALANCE_LIMIT");

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("CREATED_AT")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("CREATED_BY")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DiscNo)
                    .HasColumnName("DISC_NO")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GroupId).HasColumnName("GROUP_ID");

                entity.Property(e => e.KindCode)
                    .HasColumnName("KIND_CODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ManualCode)
                    .HasColumnName("MANUAL_CODE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Priority)
                    .HasColumnName("PRIORITY")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Remarks)
                    .HasColumnName("REMARKS")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.SubCdTypeId).HasColumnName("SUB_CD_TYPE_ID");

                entity.Property(e => e.SubGroupId).HasColumnName("SUB_GROUP_ID");

                entity.Property(e => e.TaxAmount).HasColumnName("TAX_AMOUNT");

                entity.Property(e => e.TaxLimit).HasColumnName("TAX_LIMIT");

                entity.Property(e => e.TypeId).HasColumnName("TYPE_ID");

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("UPDATED_AT")
                    .HasColumnType("datetime");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("UPDATED_BY")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AccType>(entity =>
            {
                entity.ToTable("ACC_TYPE");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasColumnName("NAME")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AgreementType>(entity =>
            {
                entity.ToTable("agreement_type");

                entity.Property(e => e.AgreementTypeId).HasColumnName("agreement_type_id");

                entity.Property(e => e.AgreementName)
                    .IsRequired()
                    .HasColumnName("agreement_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Brand>(entity =>
            {
                entity.ToTable("BRAND");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("NAME")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CustomerDetails>(entity =>
            {
                entity.ToTable("Customer_Details");

                entity.Property(e => e.BankDetails)
                    .HasColumnName("Bank_Details")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BillTo)
                    .HasColumnName("Bill_To")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Business)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPerson)
                    .HasColumnName("Contact_Person")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerBalance).HasColumnName("Customer_Balance");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Facebook)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Individual)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Instagram)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Linkedin)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTerms).HasColumnName("Payment_Terms");

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShipTo)
                    .HasColumnName("Ship_To")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShopName)
                    .HasColumnName("Shop_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShopNumber).HasColumnName("Shop_Number");

                entity.Property(e => e.TikTok)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Twitter)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Website)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.PaymentTermsNavigation)
                    .WithMany(p => p.CustomerDetails)
                    .HasForeignKey(d => d.PaymentTerms)
                    .HasConstraintName("FK_Customer_Details_Payment_terms");
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.Property(e => e.CustomerName).HasColumnName("Customer_Name");

                entity.Property(e => e.Date)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DueDate)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Invoice1)
                    .HasColumnName("Invoice#")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Particulars)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UnitPrice).HasColumnName("Unit_Price");

                entity.HasOne(d => d.CustomerNameNavigation)
                    .WithMany(p => p.Invoice)
                    .HasForeignKey(d => d.CustomerName)
                    .HasConstraintName("FK_Invoice_Customer");
            });

            modelBuilder.Entity<Month>(entity =>
            {
                entity.ToTable("month");

                entity.Property(e => e.MonthId).HasColumnName("month_id");

                entity.Property(e => e.MonthName)
                    .HasColumnName("month_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PaymentMode>(entity =>
            {
                entity.ToTable("Payment_Mode");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.PaymentMode1)
                    .HasColumnName("Payment_mode")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PaymentTerms>(entity =>
            {
                entity.ToTable("Payment_terms");

                entity.Property(e => e.PaymentTerms1)
                    .HasColumnName("Payment_Terms")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PaymentType>(entity =>
            {
                entity.ToTable("Payment_Type");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.PaymentType1)
                    .HasColumnName("PAYMENT_TYPE")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ReceivedPayments>(entity =>
            {
                entity.ToTable("Received_Payments");

                entity.Property(e => e.CustomerName).HasColumnName("Customer_Name");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.PaymentNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiptNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReferenceNumber).HasColumnName("Reference_Number");

                entity.Property(e => e.UnusedAmount)
                    .HasColumnName("Unused_Amount")
                    .HasMaxLength(50);

                entity.HasOne(d => d.CustomerNameNavigation)
                    .WithMany(p => p.ReceivedPayments)
                    .HasForeignKey(d => d.CustomerName)
                    .HasConstraintName("FK_Received_Payments_CustomerName");

                entity.HasOne(d => d.InvoiceNoNavigation)
                    .WithMany(p => p.ReceivedPayments)
                    .HasForeignKey(d => d.InvoiceNo)
                    .HasConstraintName("FK_Received_Payments_Invoice");

                entity.HasOne(d => d.ModeNavigation)
                    .WithMany(p => p.ReceivedPayments)
                    .HasForeignKey(d => d.Mode)
                    .HasConstraintName("FK_Received_Payments_Mode");

                entity.HasOne(d => d.TypeNavigation)
                    .WithMany(p => p.ReceivedPayments)
                    .HasForeignKey(d => d.Type)
                    .HasConstraintName("FK_Received_Payments_Payment_Type");
            });

            modelBuilder.Entity<Rent>(entity =>
            {
                entity.ToTable("rent");

                entity.Property(e => e.RentId).HasColumnName("rent_id");

                entity.Property(e => e.AgreementTypeId).HasColumnName("agreement_type_id");

                entity.Property(e => e.Date)
                    .IsRequired()
                    .HasColumnName("date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ElectricityBill).HasColumnName("electricity_bill");

                entity.Property(e => e.Maintenance).HasColumnName("maintenance");

                entity.Property(e => e.MonthId).HasColumnName("month_id");

                entity.Property(e => e.Rent1).HasColumnName("rent");

                entity.Property(e => e.ShopId).HasColumnName("shop_id");

                entity.Property(e => e.Year)
                    .IsRequired()
                    .HasColumnName("year")
                    .HasMaxLength(5)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Shop>(entity =>
            {
                entity.ToTable("shop");

                entity.Property(e => e.ShopId).HasColumnName("shop_id");

                entity.Property(e => e.AgreementStartDate)
                    .HasColumnName("agreement_start_date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ShopLocation)
                    .IsRequired()
                    .HasColumnName("shop_location")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShopName)
                    .IsRequired()
                    .HasColumnName("shop_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShopSize)
                    .IsRequired()
                    .HasColumnName("shop_size")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShopTypeId).HasColumnName("shop_type_id");
            });

            modelBuilder.Entity<ShopType>(entity =>
            {
                entity.ToTable("shop_type");

                entity.Property(e => e.ShopTypeId).HasColumnName("shop_type_id");

                entity.Property(e => e.ShopType1)
                    .IsRequired()
                    .HasColumnName("shop_type")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("user");

                entity.Property(e => e.UserId).HasColumnName("user_id");

                entity.Property(e => e.Address).HasColumnName("address");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasColumnName("is_active");

                entity.Property(e => e.JoiningDate)
                    .HasColumnName("joining_date")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasColumnName("password")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Phone).HasColumnName("phone");

                entity.Property(e => e.UserTypeId).HasColumnName("user_type_id");
            });

            modelBuilder.Entity<UserType>(entity =>
            {
                entity.ToTable("user_type");

                entity.Property(e => e.UserTypeId).HasColumnName("user_type_id");

                entity.Property(e => e.UserType1)
                    .HasColumnName("user_type")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<VendorDetails>(entity =>
            {
                entity.ToTable("Vendor_Details");

                entity.Property(e => e.BankDetails)
                    .HasColumnName("Bank_Details")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Business)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContactPerson)
                    .HasColumnName("Contact_Person")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Individual)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentTerms)
                    .HasColumnName("Payment_Terms")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Salutation)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VendorAddress)
                    .HasColumnName("Vendor_Address")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.VendorBalance).HasColumnName("Vendor_Balance");

                entity.Property(e => e.VendorName)
                    .HasColumnName("Vendor_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Website)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });
        }
    }
}
