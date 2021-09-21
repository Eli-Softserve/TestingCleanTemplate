using Application.Repository.Interfaces.Base;
using Domain.Common;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Repository.Interfaces
{
    public interface IStudentRepository
    {
        Task<IEnumerable<Student>> GetStudentByLastName(string lastName);
        Task<Student> CreateStudent(Student student, CancellationToken cancellationToken);
    }
}
