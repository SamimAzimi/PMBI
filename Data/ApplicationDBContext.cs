using Microsoft.EntityFrameworkCore;
using learning.Models;
namespace learning.Data;


public class ApplicationDBContext : DbContext
{
    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
    {

    }

    public DbSet<UserModel> users { get; set; }
}