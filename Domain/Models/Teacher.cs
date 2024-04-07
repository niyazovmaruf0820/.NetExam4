namespace Domain.Models;

public class Teacher
{
    public int Id { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Fname { get; set; }
    public string Iname { get; set; }
    public DateTime Dob { get; set; }
    public string Phone { get; set; }
    public string Mobile { get; set; }
    public bool Status { get; set; }
    public DateTime LastLoginDate { get; set; }
    public string LastLoginIp { get; set; }
}
