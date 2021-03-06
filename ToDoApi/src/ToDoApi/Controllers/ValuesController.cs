﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.OptionsModel;

namespace ToDoApi.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {

        private ILogger<ValuesController> logger = null;
        private IConfiguration configuration = null;
        private MyAppSettings settings = null;

        public object LoggingEvents { get; private set; }

        public ValuesController(ILogger<ValuesController> logger, IOptions<MyAppSettings> settings)
        {
            this.logger = logger;
            //this.configuration = configuration;
            this.settings = settings.Value;
        }
        // GET: api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            logger.LogInformation("++++++++++++++++++++++++Information+++++++++++++++++++++++");
            logger.LogVerbose("++++++++++++++++++++++++Verbose+++++++++++++++++++++++");
            logger.LogWarning("++++++++++++++++++++++++Warning+++++++++++++++++++++++");
            logger.LogDebug("++++++++++++++++++++++++Debug+++++++++++++++++++++++");
            logger.LogError("++++++++++++++++++++++++Error+++++++++++++++++++++++");
            logger.LogCritical("++++++++++++++++++++++++Critical+++++++++++++++++++++++");
            
            return new string[] { "value1", "value2", "values3", "values4" };
        }
         

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
