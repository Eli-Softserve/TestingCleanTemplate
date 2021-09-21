using Application.Commands.Student;
using Application.Mappers.Student;
using Application.Repository.Interfaces;
using Application.Responses.Student;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Handlers.CommandHandler.Student
{
    public class CreateStudentHandler : IRequestHandler<CreateStudentCommand, StudentResponse>
    {
        private readonly IStudentRepository _studentRepository;

        public CreateStudentHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<StudentResponse> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
        {
            var entitiy = StudentMapper.Mapper.Map<Domain.Entities.Student>(request);

            if (entitiy is null)
            {
                throw new ApplicationException("Issue with mapper");
            }

            var student = await _studentRepository.CreateStudent(entitiy, cancellationToken);
            var studentResponse = StudentMapper.Mapper.Map<StudentResponse>(student);
            return studentResponse;
        }
    }
}
