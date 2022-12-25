namespace MyBoilerplateDotNetCore6.Entities.User
{
    public class UserEntity : BaseEntity
    {

        public string UserName { get; set; }
        public string LoginId { get; set; }
        public string PasswordSalt { get; set; }
        public string PasswordHash { get; set; }
        public string PrimaryEmail { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string GenderCode { get; set; } // M | F | U
        public string PrimaryAddressLine1 { get; set; }
        public string PrimaryAddressLine2 { get; set; }
        public string PrimaryAddressSuburbOrCity { get; set; }
        public string PrimaryAddressStateOrProvience { get; set; }
        public string PrimaryAddressCountry { get; set; }
        public DateTime? IsLockedTill { get; set; }


    }
}