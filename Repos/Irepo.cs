using Web_api.Models;

namespace Web_api.Repos
{
    public interface Irepo
    {
        void Add(Student data);
        List<Student> get();
        void Update(Student data);
        void delete(int Id);
    }
}
