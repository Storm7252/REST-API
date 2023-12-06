using Microsoft.EntityFrameworkCore;
using Web_api.Models;

namespace Web_api.Context
{
    public class DContext:DbContext
    {
        public DContext(DbContextOptions opt):base(opt)
        {
            
        }
      public  DbSet<Student> students { get; set; }
    }
}
