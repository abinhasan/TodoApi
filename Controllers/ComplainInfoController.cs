using Microsoft.AspNetCore.Mvc;
using TodoApi.Domain;
using System.Collections.Generic;
using TodoApi.ServiceInterface;


namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    public class ComplainInfoController : Controller
    {
        private readonly IComplainInfoService _complainInfoService;

        public ComplainInfoController(IComplainInfoService complainInfoService)
        {
            _complainInfoService = complainInfoService;
        }

        [HttpGet]
        [Route("GetAllComplain")]
        public IEnumerable<ComplainModal> GetAllComplain()
        {
            return _complainInfoService.GetAllComplain();
        }
    }
}