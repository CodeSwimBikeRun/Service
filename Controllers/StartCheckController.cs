using System;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Service.Models;

namespace Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StartCheckController : Controller
    {
        private VersionInfo vs;
        public StartCheckController(VersionInfo vsi)
        {
            vs = vsi;
        }
        [HttpGet]
        public VersionInfo GetCurrentVersion()
        {

            return vs;
        }
    }
}