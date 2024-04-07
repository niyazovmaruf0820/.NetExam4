namespace Domain.Models;

public class Attendance
{
    public DateTime AttendanceDate { get; set; }
    public int StudentId { get; set; }
    public bool Status { get; set; }
    public string Remark { get; set; }
}
