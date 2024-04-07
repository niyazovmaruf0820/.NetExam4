using Domain.Models;
using Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WEBAPI.Cotrollers;
[ApiController]
[Route("[controller]")]
public class CourseController(Interface<Course> courseservice)
{
    [HttpGet("get-Courses")]
    public async Task<List<Course>> GetCoursesAsync()
    {
        return await courseservice.GetValuesAsync();
    }
    [HttpPost("add-Course")]
    public async Task AddCourseAsync(Course course)
    {
        await courseservice.AddValueAsync(course);
    }
    [HttpPut("update-Course")]
    public async Task UpdateTeacheAsync(Course course)
    {
        await courseservice.UpdateValueAsync(course);
    }
    [HttpDelete("delete-Course")]
    public async Task DeleteCourseAsync(int id)
    {
        await courseservice.DeleteValueAsync(id);
    }
}
