using Microsoft.EntityFrameworkCore;
using ProjetoEvent_.Context;
using ProjetoEvent_.Domains;
using ProjetoEvent_.Interfaces;
using ProjetoEvent_.Repositorios;

var builder = WebApplication.CreateBuilder(args);


// Adiciona o contexto do banco de dados (exemplo com SQL Server)
builder.Services.AddDbContext<EventPlus_Context>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));


// adicionar o repositorio e a interface ao container de injecao de dependencia
builder.Services.AddScoped<ITipoEventoRepository, TipoEventoRepository>();
builder.Services.AddScoped<ITipoUsuarioRepositoy, TipoUsuarioRepository>();

// adicionar o serviço de Controllers 
builder.Services.AddControllers();


var app = builder.Build();

// adicionar o mapeamento dos controllers
app.MapControllers();

app.Run();
