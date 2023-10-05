using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace MVCCorePractice.Models
{
    public class AddDbContextFile : IdentityDbContext<IdentityUser>
    {
        public AddDbContextFile(DbContextOptions<AddDbContextFile> options) : base(options) { }

        public DbSet<Movie> Movies { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            this.SeedUsers(builder);
            this.SeedUserRoles(builder);
            this.SeedRoles(builder);
            this.MoviesSeed(builder);
        }
        private void SeedUsers(ModelBuilder builder)
        {
            var user1 = new IdentityUser()
            {
                Id = "634a60ec-96bc-4f37-937f-27ba52f58d41",
                UserName = "admin@gmail.com",
                NormalizedUserName = "ADMIN@GMAIL.COM",
                Email = "admin@gmail.com",
                NormalizedEmail = "ADMIN@GMAIL.COM"
            };
            var user2 = new IdentityUser()
            {
                Id = "c80d49e8-a97c-45e6-babf-0760a6b86814",
                UserName = "Ishan@gmail.com",
                NormalizedUserName = "Ishan@GMAIL.COM",
                Email = "Ishan@gmail.com",
                NormalizedEmail = "Ishan@GMAIL.COM"
            };
            PasswordHasher<IdentityUser> passwordHasher = new PasswordHasher<IdentityUser>();
            user1.PasswordHash = passwordHasher.HashPassword(user1, "Admin@123");
            user2.PasswordHash = passwordHasher.HashPassword(user2, "Ishan@123");
            builder.Entity<IdentityUser>().HasData(user1);
            builder.Entity<IdentityUser>().HasData(user2);
        }

        private void SeedRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityRole>().HasData(
                new IdentityRole() { Id = "b31f9c27-4c2d-4f82-9aa8-a5a10382ca98", Name = "Admin", ConcurrencyStamp = "1", NormalizedName = "Admin" },
                new IdentityRole() { Id = "fa6f6c49-37f8-4447-a6bd-1c0a2a1353dc", Name = "User", ConcurrencyStamp = "2", NormalizedName = "User" }
        );
        }
        private void SeedUserRoles(ModelBuilder builder)
        {
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>() { RoleId = "b31f9c27-4c2d-4f82-9aa8-a5a10382ca98", UserId = "634a60ec-96bc-4f37-937f-27ba52f58d41" }
                );
            builder.Entity<IdentityUserRole<string>>().HasData(
                new IdentityUserRole<string>() { RoleId = "fa6f6c49-37f8-4447-a6bd-1c0a2a1353dc", UserId = "c80d49e8-a97c-45e6-babf-0760a6b86814" }
                );
        }

        public void MoviesSeed(ModelBuilder builder)
        {
            var movie1 = new Movie()
            {
                Id = 1,
                Name = "John Wick Chapter-4",
                Description = "Not Released",
                Title = "Action",
                Url = "Keanu Reeves"
            };

            builder.Entity<Movie>().HasData(movie1);
        }

        internal Task<IEnumerable<object>> ToListAsync()
        {
            throw new NotImplementedException();
        }
    }
}
