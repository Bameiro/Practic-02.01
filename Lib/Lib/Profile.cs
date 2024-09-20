namespace Lib
{
    public class Profile
    {
        public string Fio { get; set; }
        public string Role { get; set; }

        public Profile(string fio, string role)
        {
            Fio = fio;
            Role = role;
        }
    }

    public static class ProfileDataManager
    {
        public static Profile LoadProfile()
        {
            // Загрузка данных профиля (например, из базы данных или настроек)
            return new Profile("ФИО", "Роль");
        }
    }

}
