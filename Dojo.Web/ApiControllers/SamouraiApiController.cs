using Dojo.Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Drawing.Printing;
using System.Drawing.Text;

namespace Dojo.Web.ApiControllers
{
    public class SamouraiApiController : BaseApiController
    {
        private readonly SamouraiService _service;

        public SamouraiApiController(SamouraiService samouraiService)
        {
            _service = samouraiService;
        }

        [HttpGet("/Api/Samourais")]
        public IActionResult GetAll()
        {
            return Ok(_service.FetchAll());
        }

        [HttpGet("/Api/Paged")]
        public IActionResult GetAllPaged(int pageNumber, int pageSize)
        {
            return Ok(_service.FetchAllPaged(pageNumber, pageSize));
        }
    }
}
