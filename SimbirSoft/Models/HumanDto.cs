namespace SimbirSoft
{
    /// <summary>
    /// 2.2.1 - Класс представления пользователя
    /// </summary>
    public class HumanDto
    {
        public int ID { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string Patronymic { get; set; }
        public string Birthday { get; set; }
        public bool Writer { get; set; }
    }
}