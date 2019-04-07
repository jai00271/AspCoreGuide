namespace EFImplementation.Controllers
{
    using EFImplementation.Repository.Contracts;
    using EFImplementation.Repository.Models;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;

    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private IRepositoryWrapper _repoWrapper;

        public ValuesController(IRepositoryWrapper repositoryWrapper)
        {
            _repoWrapper = repositoryWrapper;
        }

        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var domesticAccounts = _repoWrapper.Account.FindByCondition(x => x.Equals("Domestic"));
            var owners = _repoWrapper.Owner.FindAll();

            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] Account account)
        {
            _repoWrapper.Account.Create(account);
            _repoWrapper.Account.Save();
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}