using Domain.Models;
using Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WEBAPI.Cotrollers;
[ApiController]
[Route("[controller]")]
public class AttendanceController(Interface<Attendance> attendanceservice)
{
    [HttpGet("get-Attendances")]
    public async Task<List<Attendance>> GetAttendancesAsync()
    {
        return await attendanceservice.GetValuesAsync();
    }
    [HttpPost("add-Attendance")]
    public async Task AddAttendanceAsync(Attendance Attendance)
    {
        await attendanceservice.AddValueAsync(Attendance);
    }
    [HttpPut("update-Attendance")]
    public async Task UpdateTeacheAsync(Attendance Attendance)
    {
        await attendanceservice.UpdateValueAsync(Attendance);
    }
    [HttpDelete("delete-Attendance")]
    public async Task DeleteAttendanceAsync(int id)
    {
        await attendanceservice.DeleteValueAsync(id);
    }
}
