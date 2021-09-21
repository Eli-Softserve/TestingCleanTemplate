using Api.Routes.StudentRouting;
using Application.Commands.Student;
using Application.Responses.Student;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [ApiController]
    [EnableCors("CorsPolicy")]
    public class StudentController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StudentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        /// <summary>
        /// Creates a student record
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPost(StudentRouting.Create.Post)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<StudentResponse>> CreateStudent([FromBody]CreateStudentCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }

        /// <summary>
        /// Get a single student record
        /// </summary>
        /// <param name="iId"></param>
        /// <returns></returns>
        [HttpGet(StudentRouting.GetSingle.Get)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<StudentResponse>> GetStudent([FromQuery]Guid iId)
        {
            //var result = await _mediator.Send(command);
            return Ok(200);
        }

        /// <summary>
        /// Delete a single record
        /// </summary>
        /// <param name="iId"></param>
        /// <returns></returns>
        [HttpDelete(StudentRouting.Delete.DeleteStudent)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<StudentResponse>> DeleteStudent([FromQuery]Guid iId)
        {
            //var result = await _mediator.Send(command);
            return Ok(200);
        }

        /// <summary>
        /// Update a single student record
        /// </summary>
        /// <param name="command"></param>
        /// <returns></returns>
        [HttpPut(StudentRouting.Update.UpdateStudent)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<StudentResponse>> UpdateStudent([FromBody] CreateStudentCommand command)
        {
            var result = await _mediator.Send(command);
            return Ok(result);
        }
    }
}
