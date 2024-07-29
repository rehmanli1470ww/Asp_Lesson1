using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication1.Entities;

namespace WebApplication1.Servicies
{
    public interface IStudentService
    {
        Task<List<Student>> GetAllByKeyAsync(string key = "");
        Task<List<Student>> GetByIdAsync(int id);
        
        Task AddAsync(Student student);
        Task DeleteAsync(int id);
    }
}
