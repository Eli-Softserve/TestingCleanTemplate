using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Routes.StudentRouting
{
    public static class StudentRouting
    {
        public static class Create
        {
            public const string Post = ApiRoutes.Base + "student/create";
        }

        public static class GetSingle
        {
            public const string Get = ApiRoutes.Base + "student/get_single/{iId}";
        }

        public static class Delete
        {
            public const string DeleteStudent = ApiRoutes.Base + "student/delete/{iId}";
        }

        public static class Update
        {
            public const string UpdateStudent = ApiRoutes.Base + "student/update";
        }
    }
}
