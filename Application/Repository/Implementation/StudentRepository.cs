using Application.Common.Interfaces;
using Application.Repository.Implementation.Base;
using Application.Repository.Interfaces;
using Domain.Common;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Repository.Implementation
{
    public class StudentRepository : IStudentRepository
    {
        private readonly IApplicationDbContext _context;

        public StudentRepository(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Student> CreateStudent(Student student, CancellationToken cancellationToken)
        {
            _context.tblStudents.Add(student);
            await _context.SaveChangesAsync(cancellationToken);
            return student;
        }

        public async Task<IEnumerable<Student>> GetStudentByLastName(string lastName)
        {
            return await _context.tblStudents.Where(m => m.strStudentSurname == lastName).ToListAsync();
        }
    }
}
