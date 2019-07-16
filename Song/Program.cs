using System;

namespace Song
{
    class Program
    {
        static void SingASong()
        {
            SingASong("Baby Shark");

        }

        static void SingASong(string title)
        {
            SingASong(title, "C");
            
        }

        static void SingASong(string title, string key)
        {
            Console.WriteLine($"  Let's sing {title} in the key of {key}");
            SingASong(title, key, 4);
        }

        static void SingASong(string title, string key, int nrTimes)
        {
            for (int i = 0; i < nrTimes; i++)
            {
                Console.WriteLine($"  sing: {title} (in {key})");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\n\tSong.Program.Main()\n");
            SingASong();
            SingASong("Baby Shark!", "F#");
        }
    }
}
