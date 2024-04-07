using Domain.Models;
using Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WEBAPI.Cotrollers;
[ApiController]
[Route("[controller]")]
public class ExamTypeController(Interface<ExamType> examTypeservice)
{
    [HttpGet("get-ExamTypes")]
    public async Task<List<ExamType>> GetExamTypesAsync()
    {
        return await examTypeservice.GetValuesAsync();
    }
    [HttpPost("add-ExamType")]
    public async Task AddExamTypeAsync(ExamType examType)
    {
        await examTypeservice.AddValueAsync(examType);
    }
    [HttpPut("update-ExamType")]
    public async Task UpdateTeacheAsync(ExamType examType)
    {
        await examTypeservice.UpdateValueAsync(examType);
    }
    [HttpDelete("delete-ExamType")]
    public async Task DeleteExamTypeAsync(int id)
    {
        await examTypeservice.DeleteValueAsync(id);
    }
}
