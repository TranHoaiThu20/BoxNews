using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
namespace BoxNews.Data;
public class BoxNewDbContext : DbContext
{
    public BoxNewDbContext(DbContextOptions options) : base(options)
    {

    }
}