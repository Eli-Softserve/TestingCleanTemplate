using Application.Responses.Student;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Application.Commands.Student
{
    public class CreateStudentCommand : IRequest<StudentResponse>
    {
        public string strStudentName { get; set; }
        public string strStudentSurname { get; set; }
        public string strPhoneNumber { get; set; }
        public int iGrade { get; set; }
    }
}
