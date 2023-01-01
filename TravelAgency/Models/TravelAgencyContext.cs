using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
namespace TravelAgency.Models;


public partial class TravelAgencyContext : DbContext
{
    public TravelAgencyContext()
    {
    }

    public TravelAgencyContext(DbContextOptions<TravelAgencyContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Contract> Contracts { get; set; }

    public virtual DbSet<Country> Countries { get; set; }
    public virtual DbSet<Services> Servicess { get; set; }

    public virtual DbSet<Hotel> Hotels { get; set; }

    public virtual DbSet<Insurance> Insurances { get; set; }

    public virtual DbSet<InsuranceCompany> InsuranceCompanies { get; set; }

    public virtual DbSet<Location> Locations { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<Status> Statuses { get; set; }

    public virtual DbSet<Tour> Tours { get; set; }

    public virtual DbSet<TourOperator> TourOperators { get; set; }

    public virtual DbSet<TourPackage> TourPackages { get; set; }

    public virtual DbSet<TypeFood> TypeFoods { get; set; }

    public virtual DbSet<TypeRoom> TypeRooms { get; set; }

    public virtual DbSet<TypeTour> TypeTours { get; set; }

    public virtual DbSet<TypeTourPackage> TypeTourPackages { get; set; }

    public virtual DbSet<TypeTransport> TypeTransports { get; set; }

    public virtual DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=TravelAgency;Username=postgres;Password=vfvfktyf2002");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Contract>(entity =>
        {
            entity.HasKey(e => e.IdContract).HasName("Contract_pkey");

            entity.ToTable("Contract");

            entity.Property(e => e.IdContract)
                .ValueGeneratedNever()
                .HasColumnName("id_contract ");
            entity.Property(e => e.CostDopUslugi).HasColumnName("cost_dop_uslugi");
            entity.Property(e => e.DateOfConclusion).HasColumnName("date_of_conclusion");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.NumberInsurance).HasColumnName("number_insurance");
            entity.Property(e => e.NumberInvoice).HasColumnName("number_invoice");
            entity.Property(e => e.NumberStatus).HasColumnName("number_status");
            entity.Property(e => e.NumberTour).HasColumnName("number_tour");
            entity.Property(e => e.NumberUser).HasColumnName("number_user ");
            entity.Property(e => e.QuantityTourists).HasColumnName("quantity_tourists");

        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.HasKey(e => e.IdCountry).HasName("Country_pkey");

            entity.ToTable("Country");

            entity.Property(e => e.IdCountry)
                .ValueGeneratedNever()
                .HasColumnName("id_country");
            entity.Property(e => e.NameCountry).HasColumnName("name_country");
        });

        modelBuilder.Entity<Hotel>(entity =>
        {
            entity.HasKey(e => e.IdHotel).HasName("Hotel_pkey");

            entity.ToTable("Hotel");

            entity.Property(e => e.IdHotel)
                .ValueGeneratedNever()
                .HasColumnName("id_hotel");
            entity.Property(e => e.Adress).HasColumnName("adress");
            entity.Property(e => e.NameHotel).HasColumnName("name_hotel");
            entity.Property(e => e.NumberCountry).HasColumnName("number_country");
            entity.Property(e => e.Stars).HasColumnName("stars");


        });
        modelBuilder.Entity<Services>(entity =>
        {
            entity.HasKey(e => e.id_services).HasName("Services_pkey");

            entity.ToTable("Services");

            entity.Property(e => e.id_services)
                .ValueGeneratedNever()
                .HasColumnName("id_services");
            entity.Property(e => e.port).HasColumnName("port");
            entity.Property(e => e.name).HasColumnName("name");
            entity.Property(e => e.host).HasColumnName("host");
            entity.Property(e => e.entered).HasColumnName("entered");
        }

            );


            modelBuilder.Entity<Insurance>(entity =>
        {
            entity.HasKey(e => e.IdInsurance).HasName("Insurance_pkey");

            entity.ToTable("Insurance");

            entity.Property(e => e.IdInsurance)
                .ValueGeneratedNever()
                .HasColumnName("id_insurance ");
            entity.Property(e => e.DateLicense).HasColumnName("date_license");
            entity.Property(e => e.Description).HasColumnName("description");
            entity.Property(e => e.NameInsurance).HasColumnName("name_insurance");
            entity.Property(e => e.NumberInsuranceCompany).HasColumnName("number_insurance_company");
            entity.Property(e => e.Price).HasColumnName("price");


        });

            modelBuilder.Entity<InsuranceCompany>(entity =>
            {
                entity.HasKey(e => e.IdInsuranceCompany).HasName(" Insurance_company_pkey");

                entity.ToTable(" Insurance_company");

                entity.Property(e => e.IdInsuranceCompany)
                    .ValueGeneratedNever()
                    .HasColumnName("id_insurance_company ");
                entity.Property(e => e.NameInsuranceCompany).HasColumnName("name_insurance_company");
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.HasKey(e => e.IdLocation).HasName("Location_pkey");

                entity.ToTable("Location");

                entity.Property(e => e.IdLocation)
                    .ValueGeneratedNever()
                    .HasColumnName("id_location");
                entity.Property(e => e.NumberCountry).HasColumnName("number_country");
                entity.Property(e => e.Place).HasColumnName("place");


            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.HasKey(e => e.IdRole).HasName("Role_pkey");

                entity.ToTable("Role");

                entity.Property(e => e.IdRole)
                    .ValueGeneratedNever()
                    .HasColumnName("id_role");
                entity.Property(e => e.NameRole).HasColumnName("name_role");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.HasKey(e => e.IdStatus).HasName("Status_pkey");

                entity.ToTable("Status");

                entity.Property(e => e.IdStatus)
                    .ValueGeneratedNever()
                    .HasColumnName("id_status");
                entity.Property(e => e.NameStatus).HasColumnName("name_status");
            });

            modelBuilder.Entity<Tour>(entity =>
            {
                entity.HasKey(e => e.IdTour).HasName("Tour_pkey");

                entity.ToTable("Tour");

                entity.Property(e => e.IdTour)
                    .ValueGeneratedNever()
                    .HasColumnName("id_tour");
                entity.Property(e => e.AmountSeats).HasColumnName("amount_seats");
                entity.Property(e => e.ArrivalDate).HasColumnName("arrival_date");
                entity.Property(e => e.DepartureDate).HasColumnName("departure_date");
                entity.Property(e => e.Description).HasColumnName("description");
                entity.Property(e => e.NumberLocation).HasColumnName("number_location");
                entity.Property(e => e.NumberTourOperator).HasColumnName("number_tour_operator");
                entity.Property(e => e.NumberTypeTour).HasColumnName("number_type_tour");
                entity.Property(e => e.Price).HasColumnName("price ");
                entity.Property(e => e.Remark).HasColumnName("remark");

            });

            modelBuilder.Entity<TourOperator>(entity =>
            {
                entity.HasKey(e => e.IdTourOperator).HasName("Tour_operator_pkey");

                entity.ToTable("Tour_operator");

                entity.Property(e => e.IdTourOperator)
                    .ValueGeneratedNever()
                    .HasColumnName("id_tour_operator");
                entity.Property(e => e.Address).HasColumnName("address");
                entity.Property(e => e.DateOfContract).HasColumnName("date_of_contract");
                entity.Property(e => e.Email).HasColumnName("email");
                entity.Property(e => e.NameTourOperator).HasColumnName("name_tour_operator");
                entity.Property(e => e.NumberPhone).HasColumnName("number_phone");
                entity.Property(e => e.NumberRegistration).HasColumnName("number_registration");
            });

            modelBuilder.Entity<TourPackage>(entity =>
            {
                entity.HasKey(e => e.IdTourPackage).HasName("Tour_package_pkey");

                entity.ToTable("Tour_package");

                entity.Property(e => e.IdTourPackage)
                    .ValueGeneratedNever()
                    .HasColumnName("id_tour_package");
                entity.Property(e => e.DateStart).HasColumnName("date_start");
                entity.Property(e => e.Description).HasColumnName("description");
                entity.Property(e => e.NumberCertification).HasColumnName("number_certification");
                entity.Property(e => e.NumberHotel).HasColumnName("number_hotel");
                entity.Property(e => e.NumberTypeFood).HasColumnName("number_type_food");
                entity.Property(e => e.NumberTypeRoom).HasColumnName("number_type_room");
                entity.Property(e => e.NumberTypeTransport).HasColumnName("number_type_transport");
                entity.Property(e => e.PopularityRate).HasColumnName("popularity_rate");


            });

            modelBuilder.Entity<TypeFood>(entity =>
            {
                entity.HasKey(e => e.IdTypeFood).HasName("Type_food_pkey");

                entity.ToTable("Type_food");

                entity.Property(e => e.IdTypeFood)
                    .ValueGeneratedNever()
                    .HasColumnName("id_ type_food");
                entity.Property(e => e.NameTypeFood).HasColumnName("name_type_food");
            });

            modelBuilder.Entity<TypeRoom>(entity =>
            {
                entity.HasKey(e => e.IdTypeRoom).HasName("Type_room_pkey");

                entity.ToTable("Type_room");

                entity.Property(e => e.IdTypeRoom)
                    .ValueGeneratedNever()
                    .HasColumnName("id_type_room");
                entity.Property(e => e.NameTypeRoom).HasColumnName("name_type_room");
            });

            modelBuilder.Entity<TypeTour>(entity =>
            {
                entity.HasKey(e => e.IdTepyTour).HasName("Type_tour_pkey");

                entity.ToTable("Type_tour");

                entity.Property(e => e.IdTepyTour)
                    .ValueGeneratedNever()
                    .HasColumnName("id_tepy_tour");
                entity.Property(e => e.Name).HasColumnName("name");
            });

            modelBuilder.Entity<TypeTourPackage>(entity =>
            {
                entity
                    .HasNoKey()
                    .ToTable("Type_tour_package");

                entity.Property(e => e.TourId).HasColumnName("tour_id ");
                entity.Property(e => e.TourPackageId).HasColumnName("tour_package_id");
            });

            modelBuilder.Entity<TypeTransport>(entity =>
            {
                entity.HasKey(e => e.IdTypeTransport).HasName("Type_transport_pkey");

                entity.ToTable("Type_transport");

                entity.Property(e => e.IdTypeTransport)
                    .ValueGeneratedNever()
                    .HasColumnName("id_type_transport");
                entity.Property(e => e.NameTypeTransport).HasColumnName("name_ type_transport");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.IdUser).HasName("User_pkey");

                entity.ToTable("User");

                entity.Property(e => e.IdUser)
                    .ValueGeneratedNever()
                    .HasColumnName("id_user");
                entity.Property(e => e.City).HasColumnName("city");
                entity.Property(e => e.Fullname).HasColumnName("fullname");
                entity.Property(e => e.Login).HasColumnName("login");
                entity.Property(e => e.Number).HasColumnName("number");
                entity.Property(e => e.NumberRole).HasColumnName("number_role");
                entity.Property(e => e.PassportNumber).HasColumnName("passport_number");
                entity.Property(e => e.Password).HasColumnName("password");

            });

            OnModelCreatingPartial(modelBuilder);
        }


        

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
