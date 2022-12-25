using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MyBoilerplateDotNetCore6.Entities.User
{
    public class UserEntityMapping : IEntityTypeConfiguration<UserEntity>
    {

        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.ToTable("Users");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.UserName).IsRequired().HasMaxLength(100).IsUnicode(false);
            builder.Property(x => x.LoginId).IsRequired().HasMaxLength(30).IsUnicode(false);
            builder.Property(x => x.PasswordSalt).IsRequired().HasMaxLength(50).IsUnicode(false);
            builder.Property(x => x.PasswordHash).IsRequired().HasMaxLength(50).IsUnicode(false);
            builder.Property(x => x.PrimaryEmail).IsRequired().HasMaxLength(255).IsUnicode(false);
            builder.Property(x => x.DateOfBirth).IsRequired(false);
            builder.Property(x => x.GenderCode).IsRequired().HasMaxLength(2).IsUnicode(false);
            builder.Property(x => x.PrimaryAddressLine1).IsRequired().HasMaxLength(100).IsUnicode(false);
            builder.Property(x => x.PrimaryAddressLine2).IsRequired().HasMaxLength(100).IsUnicode(false);
            builder.Property(x => x.PrimaryAddressSuburbOrCity).IsRequired().HasMaxLength(100).IsUnicode(false);
            builder.Property(x => x.PrimaryAddressStateOrProvience).IsRequired().HasMaxLength(100).IsUnicode(false);
            builder.Property(x => x.PrimaryAddressCountry).IsRequired().HasMaxLength(5).IsUnicode(false);
            builder.Property(x => x.IsLockedTill).IsRequired(false);
        }

    }
}
