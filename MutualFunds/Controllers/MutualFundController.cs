using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
//using MutualFunds.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MutualFunds.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MutualFundController : ControllerBase
    {
        private readonly ILogger<MutualFundController> _logger;

        public MutualFundController(ILogger<MutualFundController> logger)
        {
            _logger = logger;
        }

        //[httpget]
        //public list<mutualfundentities> get()
        //{

        //}


        //Fund Search services parameters {SchemeCode, SchemeName}



    }
}
