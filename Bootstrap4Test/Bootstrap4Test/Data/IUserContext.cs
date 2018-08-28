using Bootstrap4Test.DomainModels;
using Microsoft.EntityFrameworkCore;

namespace Bootstrap4Test.Data
{
    public interface IUserContext
    {
        DbSet<User> Users { get; set; }
    }
}