namespace ReservationServiceAPI.Controllers.Models;

public class Customer
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public int PhoneNumber { get; set; }
    public string Address { get; set; }
    
    // Constructor
    public Customer(int id, string name, string email, int phoneNumber)
    {
        Id = id;
        Name = name;
        Email = email;
        PhoneNumber = phoneNumber;
        Address = string.Empty; // Default value
    }
}









