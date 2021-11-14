using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

/// <summary>
/// 3 - Контроллер, отвечающий за человека
/// </summary>
namespace SimbirSoft.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HumanController : ControllerBase
    {
        /// <summary>
        /// 3.1.1 Get для всех людей
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<HumanDto> GetHumans()
        {
            return TestData.GetHumansList();
        }

        /// <summary>
        /// 3.1.2 Get для всех людей, которые пишут книги
        /// </summary>
        /// <returns></returns>
        //[HttpGet]
        //public IEnumerable<HumanDto> Get

        /// <summary>
        /// 3.1.3 Get для всех людей, в имени, фамилии или отчестве которых содержится поисковая фраза (query).
        /// </summary>
        /// <returns></returns>
        //[HttpGet]
        //public IEnumerable<HumanDto> Get

    }
}
