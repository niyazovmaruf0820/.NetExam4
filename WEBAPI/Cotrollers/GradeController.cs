using Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using Infrastructure.Interfaces;
using Dapper;
using Domain.Models;

namespace WEBAPI.Cotrollers;
[ApiController]
[Route("[controller]")]
public class GradeController(Interface<Grade> gradeservice)
{
    [HttpGet("get-Grades")]
    public async Task<List<Grade>> GetGradesAsync()
    {
        return await gradeservice.GetValuesAsync();
    }
    [HttpPost("add-Grade")]
    public async Task AddGradeAsync(Grade grade)
    {
        await gradeservice.AddValueAsync(grade);
    }
    [HttpPut("update-Grade")]
    public async Task UpdateTeacheAsync(Grade grade)
    {
        await gradeservice.UpdateValueAsync(grade);
    }
    [HttpDelete("delete-Grade")]
    public async Task DeleteGradeAsync(int id)
    {
        await gradeservice.DeleteValueAsync(id);
    }
}
