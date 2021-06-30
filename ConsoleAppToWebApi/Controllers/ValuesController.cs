using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleAppToWebApi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class ValuesController : ControllerBase
    {
        [Route("~/get-all")]
        //[Route("getall")]
        //[Route("all")]
        public string GetAll()
        {
            return "Get All";
        }
        //[Route("api/get-all-books")]
        public string GetAllBook()
        {
            return "Get All Books";
        }
        //[Route("book-by-id/{id}/{name}")]
        [Route("{id}/{name}")]
        public string GetAllBook(int id, string name)
        {
            return $"Book id is {id} and {name}";
        }
        
        /// query string search?id=5&name=ramayan&author=valmiki
        //[Route("search")]
        public string GetAllBook(int id, string name, string author)
        {
            return $"Book id is {id} and {name} {author}";
        }
    }
}
