namespace Modul12.HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User();
            user1.Login = "Flamer";
            user1.Name = "Ilya";
            user1.IsPremium = true;

            User user2 = new User();
            user2.Login = "Yaks";
            user2.Name = "Yakov";
            user2.IsPremium = false;

            List<User> users = new List<User>();
            users.Add(user1);
            users.Add(user2);

            foreach (User user in users)
            {
                Console.WriteLine("Здравствуйте, " + user.Name);
                if (!user.IsPremium)
                {
                    User.ShowAds();
                }
                Console.WriteLine("--------------------------------------");
            }
        }
    }
}
