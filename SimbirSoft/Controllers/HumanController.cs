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
        [HttpGet("writers")]
        public IEnumerable<HumanDto> GetWriters()
        {
            return TestData.GetHumansList().Where(unit => unit.Writer == true);
        }

        /// <summary>
        /// 3.1.3 Get для всех людей, в имени, фамилии или отчестве которых содержится поисковая фраза (query).
        /// </summary>
        /// <returns></returns>
        [HttpGet("search")]
        public IEnumerable<HumanDto> GetHumanByString(string queryStr)
        {
            // queryStr на пустую строку
            if (queryStr == null)
                return GetHumans();

            // Переводим строку в нижний регистр
            queryStr = queryStr.ToLower();

            // Объявляем новый список для отбора необходимых людей
            var list = new List<HumanDto>();

            foreach (var unit in TestData.GetHumansList())
            {
                // Складываем части полного имени в одну строку
                string FullName = unit.Name + unit.Patronymic + unit.Surname;

                // Переводим строку в нижний регистр
                FullName = FullName.ToLower();

                if (FullName.Contains(queryStr))
                    list.Add(unit);
            }

            return list;
        }

        /// <summary>
        /// 3.2 POST добавляющий нового человека.
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public void AddHuman([FromBody] HumanDto unit)
        {
            // При передаче ID игнорируется
            TestData.AddHumanToList(new HumanDto { Surname = unit.Surname, Name = unit.Name, 
                Patronymic = unit.Patronymic, Birthday = unit.Birthday, Writer = unit.Writer });
        }

        /// <summary>
        /// 3.3 DELETE удаляющий человека.
        /// </summary>
        /// <returns></returns>
        [HttpDelete]
        public void DeleteHuman(int id)
        {
            TestData.GetHumansList().RemoveAll(unit => unit.ID == id);
        }
    }
}
