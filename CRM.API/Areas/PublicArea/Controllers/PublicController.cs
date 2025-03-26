﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CRM.API.Areas.PublicArea.Controllers


{
    [Area("PublicArea")]
    [DisplayName("Public Controller")]
    [Route("PublicArea/[controller]")]
    

   

    [ApiController]
    public class PublicController : ControllerBase
    {
        [HttpGet]

        public IActionResult Get()
        {
            return Ok("Hello Public Area");
        }
    }
}
