using Domain.Models;
using Infrastructure.Data;
using Infrastructure.Interfaces;
using Infrastructure.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();
builder.Services.AddSingleton<DapperContext>();
builder.Services.AddScoped<Interface<Attendance>,AttendanceService>();
builder.Services.AddScoped<Interface<Classroom>,ClassroomService>();
builder.Services.AddScoped<Interface<ClassroomStudent>,ClassroomStudentService>();
builder.Services.AddScoped<Interface<Course>,CourseService>();
builder.Services.AddScoped<Interface<ExamResult>,ExamResultService>();
builder.Services.AddScoped<Interface<Exam>,ExamService>();
builder.Services.AddScoped<Interface<ExamType>,ExamTypeService>();
builder.Services.AddScoped<Interface<Grade>,GradeService>();
builder.Services.AddScoped<Interface<Parent>,ParentService>();
builder.Services.AddScoped<Interface<Teacher>,TeacherService>();
builder.Services.AddScoped<Interface<Student>,StudentService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();




app.MapControllers();
app.Run();


