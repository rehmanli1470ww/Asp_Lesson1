﻿using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication1.Entities;

namespace WebApplication1.Repositories
{
    public interface IStudentRepository
    {
        Task<List<Student>> GetAllAsync(string key);
        Task<List<Student>> GetIdAsync(int id);
        Task AddAsync(Student student);
        Task DeleteAsync(int id);
    }
}
