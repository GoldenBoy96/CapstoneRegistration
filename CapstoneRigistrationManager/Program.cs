using BussinessLogic.Implement;
using BussinessLogic.Abstraction;
using DataAccessObject;
using Microsoft.EntityFrameworkCore;
using Repository.IRepository;
using Repository.Repository;
using Repository.UnitOfWork;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();

IConfigurationRoot configuration = (new ConfigurationBuilder())
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();
//builder.Services.AddDbContext<CapstoneRigistrationContext>(option =>
//{
//    option.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));
//});


//Repository
builder.Services.AddSingleton<IGroupRepo, GroupRepo>();
builder.Services.AddSingleton<ILecturerInGroupRepo, LecturerInGroupRepo>();
builder.Services.AddSingleton<ILecturerRepo, LecturerRepo>();
builder.Services.AddSingleton<ISemesterRepo, SemesterRepo>();
builder.Services.AddSingleton<IStudentInGroupRepo, StudentInGroupRepo>();
builder.Services.AddSingleton<IStudentInSemesterRepo, StudentInSemesterRepo>();
builder.Services.AddSingleton<IStudentRepo, StudentRepo>();
builder.Services.AddSingleton<ITopicOfLecturerRepo, TopicOfLecturerRepo>();
builder.Services.AddSingleton<ITopicRepo, TopicRepo>();
builder.Services.AddSingleton<IUnitOfWork, UnitOfWork>();

//Service
builder.Services.AddTransient<IStudentService, StudentService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
