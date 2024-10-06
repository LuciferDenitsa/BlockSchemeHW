using System;

namespace BlockSchemeHW
{
    class Program
    {

        public static void Main(string[] args)
        {
            List<User> users = new List<User>();
            users.Add(new User("DanMan", "Daniil", true));
            users.Add(new User("RomaKaif", "Roman", false));
            users.Add(new User("SanyaTop", "Alex", false));
            users.Add(new User("MartaBeaauty", "Marta", true));
            users.Add(new User("Roger123", "Roger", true));

            foreach (User user in users)
            {
                Console.WriteLine($"Hello, {user.Name}!");
                if (!user.IsPremium)
                    Reklama.ShowAds();
                Console.WriteLine();
            }

        }


    }
}
