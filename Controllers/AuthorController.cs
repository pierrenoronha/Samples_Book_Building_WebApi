using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Samples_Book_Building_WebApi.Models;

namespace Samples_Book_Building_WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthorController : ControllerBase
    {
        private static readonly IEnumerable<Author> Authors = new []
        {
            new Author { FirstName = "Pierre", LastName = "Noronha", BirthDate = new DateTime(1981, 04, 13) },
            new Author { FirstName = "Kawã", LastName = "Noronha", BirthDate = new DateTime(2005, 08, 18) },
            new Author { FirstName = "Tatiane", LastName = "Noronha", BirthDate = new DateTime(1985, 05, 12) },
            new Author { FirstName = "Amora", LastName = "Preta", BirthDate = new DateTime(1985, 05, 12) },
            new Author { FirstName = "Thomas", LastName = "Autista", BirthDate = new DateTime(1985, 05, 12) },
        };

        private readonly ILogger<AuthorController> _logger;

        public AuthorController(ILogger<AuthorController> logger)
        {
            _logger = logger;
        }

        [HttpGet("/Authors")]
        public IEnumerable<Author> Get()
        {
            return Authors;
        }
    }
}
