namespace CustRegOnboarding.Domain
{
    public class Customer
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
        public string Signature { get; set; } // base64
    }
}
