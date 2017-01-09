using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Angular2WebApi.Controllers
{
    using ApplicationService.Services;
    using ApplicationService.Models;

    public class HeroController : ApiController
    {
        private readonly HeroService _heroService;

        public HeroController()
        {
            _heroService = new HeroService();
        }

        public IEnumerable<HeroModel> GetHeros() 
        {
            var heroes = _heroService.GetHeroes();
            return heroes;

            //Du ska precis skicka en lista med hjältar till klienten.
            //https://angular.io/docs/ts/latest/tutorial/toh-pt6.html
        }

        // GET api/<controller>
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<controller>/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<controller>
        public void Post([FromBody]string value)
        {
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)  //Certifierings plugg. Vad är skillnaden mellan FromBody och UriBody.
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}