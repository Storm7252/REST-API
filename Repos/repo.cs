using Web_api.Context;
using Web_api.Models;

namespace Web_api.Repos
{
    public class repo : Irepo
    {
        private readonly DContext context;

        public repo(DContext _context)
        {
            context = _context;
        }

        public void Add(Student data)
        {
            context.students.Add(data);
            context.SaveChanges();

        }
        public List<Student> get()
        {

            var res = context.students.ToList();
            return res;
        }
        public void Update(Student data)
        {
            context.students.Update(data);
            context.SaveChanges();
        }
        public void delete(int Id)
        {
            var res = context.students.Where(item => item.Id == Id).FirstOrDefault();
            context.students.Remove(res);
            context.SaveChanges();
        }
    }
}
