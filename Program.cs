using System;

namespace BlockSchemeHW
{
    class Program
    {

        public static void Main(string[] args)
        {
            List<User> users = new List<User>();
            users.Add(new User("Tom123", "Tom", true));
            users.Add(new User("MiKe_005", "Mike", false));
            users.Add(new User("Alex__O", "Alex", false));
            users.Add(new User("AgataSnow", "Agata", true));
            users.Add(new User("Mr_smith", "Nick", true));

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
