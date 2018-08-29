using AngularTest.Models;
using Microsoft.EntityFrameworkCore;

namespace AngularTest.Data
{
    public interface IUserContext
    {
        DbSet<User> Users { get; set; }
    }
}