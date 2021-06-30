using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ConsoleAppToWebApi.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class BookController : ControllerBase
    {
        [Route("{id:int:min(10):max(40):required}")]
        public string GetAllBook(int id)
        {
            return $"Book id is {id}";
        }
        [Route("{name:minlength(5):maxlength(10)}")]
        public string GetAllBook(string name)
        {
            return $"Book name is {name}";
        }
        [Route("{name:length(5):alpha}")]
        public string GetAllBooks(string name)
        {
            return $"Book name is {name}";
        }
    }
}
