using Microsoft.EntityFrameworkCore;
using trackingapi.Data;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//builder.Services.AddDbContext<IssueDbContext>(
//    o => o.UseSqlServer(builder.Configuration.GetConnectionString("SqlServer")));

builder.Services.AddDbContext<IssueDbContext>(
    o => o.UseSqlite("Data Source=Db/issue.db"));

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.EnsureDatabaseCreated(); // extension
System.Console.WriteLine("3rf32r2");
app.Run();
