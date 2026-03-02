using IOMA.API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration["ConnectionString:IOMAConnectionString"];

if(string.IsNullOrEmpty(connectionString)) {
    throw new InvalidOperationException("Connection string não configurada.");
}

builder.Services.AddControllers();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<IOMADbContext>(options =>
    options.UseSqlServer(connectionString));

var app = builder.Build();

if(app.Environment.IsDevelopment()) {
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseRouting();
app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

app.Run();
