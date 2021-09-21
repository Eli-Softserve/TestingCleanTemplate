using Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Entities
{
    public class Student : AuditableEntity
    {
        public int iStudentId { get; set; }
        public string strStudentName { get; set; }
        public string strStudentSurname { get; set; }
        public string strPhoneNumber { get; set; }
        public int iGrade { get; set; }
    }
}
