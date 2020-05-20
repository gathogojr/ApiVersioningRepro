using ApiVersioningRepro.Models;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Query;
using Microsoft.AspNet.OData.Routing;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.ObjectModel;
using System.Linq;

namespace ApiVersioningRepro.Controllers
{
    [ODataFormatting]
    [ODataRouting]
    [ApiVersion("1.0")]
    public class PersonsController : ODataController
    {
        private static readonly Collection<Person> _persons = new Collection<Person>
        {
            new Person
            {
                Id = Guid.Empty,
                Name = "Person 1"
            }
        };

        [EnableQuery(PageSize = 10, AllowedOrderByProperties = "Id", AllowedQueryOptions = AllowedQueryOptions.All)]
        [HttpGet]
        [ODataRoute]
        public ActionResult<IQueryable<Person>> Get(ODataQueryOptions<Person> options)
        {
            return Ok(_persons.AsQueryable());
        }
    }
}
