namespace TrowulanForm.Models
{
    public class Registration
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Package { get; set; }
        public int Adult { get; set; }
        public int? Children { get; set; }
        public DateTime Date { get; set; }
        public string PaymentType { get; set; }
        public string? Message { get; set; }
    }

}
