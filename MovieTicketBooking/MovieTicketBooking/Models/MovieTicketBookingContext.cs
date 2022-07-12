using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace MovieTicketBooking.Models
{
    public partial class MovieTicketBookingContext : DbContext
    {
        public MovieTicketBookingContext()
        {
        }

        public MovieTicketBookingContext(DbContextOptions<MovieTicketBookingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; }
        public virtual DbSet<AgeLimit> AgeLimits { get; set; }
        public virtual DbSet<Customer> Customers { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<FavouriteList> FavouriteLists { get; set; }
        public virtual DbSet<Genre> Genres { get; set; }
        public virtual DbSet<GenreMovie> GenreMovies { get; set; }
        public virtual DbSet<Manager> Managers { get; set; }
        public virtual DbSet<Movie> Movies { get; set; }
        public virtual DbSet<Print> Prints { get; set; }
        public virtual DbSet<Rating> Ratings { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<Room> Rooms { get; set; }
        public virtual DbSet<Showtime> Showtimes { get; set; }
        public virtual DbSet<ShowtimeOrder> ShowtimeOrders { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=localhost;Database=MovieTicketBooking;user=sa;password=123456789");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("Account");

                entity.Property(e => e.AccountId).HasColumnName("AccountID");

                entity.Property(e => e.Email).HasMaxLength(255);

                entity.Property(e => e.Password)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.Accounts)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK__Account__RoleID__4316F928");
            });

            modelBuilder.Entity<AgeLimit>(entity =>
            {
                entity.ToTable("AgeLimit");

                entity.Property(e => e.AgeLimitId)
                    .ValueGeneratedNever()
                    .HasColumnName("AgeLimitID");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(255);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.Property(e => e.CustomerId)
                    .ValueGeneratedNever()
                    .HasColumnName("CustomerID");

                entity.Property(e => e.CustomerName).HasMaxLength(255);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.CustomerNavigation)
                    .WithOne(p => p.Customer)
                    .HasForeignKey<Customer>(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Customer__Custom__45F365D3");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("Employee");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FavouriteList>(entity =>
            {
                entity.ToTable("FavouriteList");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.MovieId).HasColumnName("MovieID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.FavouriteLists)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK__Favourite__Custo__52593CB8");

                entity.HasOne(d => d.Movie)
                    .WithMany(p => p.FavouriteLists)
                    .HasForeignKey(d => d.MovieId)
                    .HasConstraintName("FK__Favourite__Movie__534D60F1");
            });

            modelBuilder.Entity<Genre>(entity =>
            {
                entity.ToTable("Genre");

                entity.Property(e => e.GenreId)
                    .ValueGeneratedNever()
                    .HasColumnName("GenreID");

                entity.Property(e => e.GenreName).HasMaxLength(255);
            });

            modelBuilder.Entity<GenreMovie>(entity =>
            {
                entity.HasKey(e => new { e.GenreId, e.MovieId })
                    .HasName("PK__GenreMov__B7382C1D33DD5418");

                entity.ToTable("GenreMovie");

                entity.Property(e => e.GenreId).HasColumnName("GenreID");

                entity.Property(e => e.MovieId).HasColumnName("MovieID");

                entity.HasOne(d => d.Genre)
                    .WithMany(p => p.GenreMovies)
                    .HasForeignKey(d => d.GenreId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__GenreMovi__Genre__3D5E1FD2");

                entity.HasOne(d => d.Movie)
                    .WithMany(p => p.GenreMovies)
                    .HasForeignKey(d => d.MovieId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__GenreMovi__Movie__3E52440B");
            });

            modelBuilder.Entity<Manager>(entity =>
            {
                entity.ToTable("Manager");

                entity.Property(e => e.ManagerId).HasColumnName("ManagerID");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Phone)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Movie>(entity =>
            {
                entity.ToTable("Movie");

                entity.Property(e => e.MovieId).HasColumnName("MovieID");

                entity.Property(e => e.Actor)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.MovieName)
                    .IsRequired()
                    .HasMaxLength(255);

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.Trailer).HasMaxLength(255);

                entity.HasOne(d => d.AgeLimitNavigation)
                    .WithMany(p => p.Movies)
                    .HasForeignKey(d => d.AgeLimit)
                    .HasConstraintName("FK__Movie__AgeLimit__3A81B327");
            });

            modelBuilder.Entity<Print>(entity =>
            {
                entity.ToTable("Print");

                entity.Property(e => e.PrintId).HasColumnName("PrintID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.TicketId).HasColumnName("TicketID");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Prints)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK__Print__EmployeeI__6477ECF3");

                entity.HasOne(d => d.Ticket)
                    .WithMany(p => p.Prints)
                    .HasForeignKey(d => d.TicketId)
                    .HasConstraintName("FK__Print__TicketID__6383C8BA");
            });

            modelBuilder.Entity<Rating>(entity =>
            {
                entity.HasKey(e => e.RateId)
                    .HasName("PK__Rating__58A7CCBC2F5DE65E");

                entity.ToTable("Rating");

                entity.Property(e => e.RateId)
                    .ValueGeneratedNever()
                    .HasColumnName("RateID");

                entity.Property(e => e.ContentRate).HasMaxLength(255);

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.MovieId).HasColumnName("MovieID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Ratings)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK__Rating__Customer__49C3F6B7");

                entity.HasOne(d => d.Movie)
                    .WithMany(p => p.Ratings)
                    .HasForeignKey(d => d.MovieId)
                    .HasConstraintName("FK__Rating__MovieID__48CFD27E");
            });

            modelBuilder.Entity<Role>(entity =>
            {
                entity.ToTable("Role");

                entity.Property(e => e.RoleId)
                    .ValueGeneratedNever()
                    .HasColumnName("RoleID");

                entity.Property(e => e.RoleName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Room>(entity =>
            {
                entity.ToTable("Room");

                entity.Property(e => e.RoomId)
                    .ValueGeneratedNever()
                    .HasColumnName("RoomID");

                entity.Property(e => e.Description).HasMaxLength(1);
            });

            modelBuilder.Entity<Showtime>(entity =>
            {
                entity.ToTable("Showtime");

                entity.Property(e => e.ShowtimeId).HasColumnName("ShowtimeID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.MovieId).HasColumnName("MovieID");

                entity.Property(e => e.RoomId).HasColumnName("RoomID");

                entity.HasOne(d => d.Movie)
                    .WithMany(p => p.Showtimes)
                    .HasForeignKey(d => d.MovieId)
                    .HasConstraintName("FK__Showtime__MovieI__571DF1D5");

                entity.HasOne(d => d.Room)
                    .WithMany(p => p.Showtimes)
                    .HasForeignKey(d => d.RoomId)
                    .HasConstraintName("FK__Showtime__RoomID__5629CD9C");
            });

            modelBuilder.Entity<ShowtimeOrder>(entity =>
            {
                entity.HasKey(e => e.OrderId)
                    .HasName("PK__Showtime__C3905BAFAE3BC289");

                entity.ToTable("ShowtimeOrder");

                entity.Property(e => e.OrderId).HasColumnName("OrderID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Date).HasColumnType("date");

                entity.Property(e => e.MovieId).HasColumnName("MovieID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ShowtimeOrders)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK__ShowtimeO__Custo__5AEE82B9");

                entity.HasOne(d => d.Movie)
                    .WithMany(p => p.ShowtimeOrders)
                    .HasForeignKey(d => d.MovieId)
                    .HasConstraintName("FK__ShowtimeO__Movie__59FA5E80");
            });

            modelBuilder.Entity<Ticket>(entity =>
            {
                entity.ToTable("Ticket");

                entity.Property(e => e.TicketId).HasColumnName("TicketID");

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.EmployeeId).HasColumnName("EmployeeID");

                entity.Property(e => e.Place)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ShowtimeId).HasColumnName("ShowtimeID");

                entity.Property(e => e.TimeOrder)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Tickets)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK__Ticket__Customer__5EBF139D");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Tickets)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK__Ticket__Employee__60A75C0F");

                entity.HasOne(d => d.Showtime)
                    .WithMany(p => p.Tickets)
                    .HasForeignKey(d => d.ShowtimeId)
                    .HasConstraintName("FK__Ticket__Showtime__5DCAEF64");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
