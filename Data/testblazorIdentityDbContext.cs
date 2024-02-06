using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace testblazor.Data
{
    public class testblazorIdentityDbContext(DbContextOptions<testblazorIdentityDbContext> options) : IdentityDbContext<IdentityUser>(options)
    {
    }
}
