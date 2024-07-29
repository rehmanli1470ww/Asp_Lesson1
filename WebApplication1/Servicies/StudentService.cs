using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication1.Entities;
using WebApplication1.Repositories;

namespace WebApplication1.Servicies
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task AddAsync(Student student)
        {
            await _studentRepository.AddAsync(student);
        }

        public async Task DeleteAsync(int id)
        {
           await _studentRepository.DeleteAsync(id);
        }

        public async Task<List<Student>> GetAllByKeyAsync(string key="")
        {
            return await _studentRepository.GetAllAsync(key);
        }

        public async Task<List<Student>> GetByIdAsync(int id)
        {
            return await _studentRepository.GetIdAsync(id);
        }
        

    }
}
