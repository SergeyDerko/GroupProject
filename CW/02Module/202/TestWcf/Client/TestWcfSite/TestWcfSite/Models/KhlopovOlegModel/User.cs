namespace TestWcfSite.Models.KhlopovOlegModel
{
    public class User
    {
        public string name { get; set; }
        public int age { get; set; }
        public string sex { get; set; }

        public string Result()
        {
            var res = "Добрый день: " + name + " ваш возраст: " + age + " и пол: " + sex;
            return res;
        }
    }
}