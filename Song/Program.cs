using System;

namespace Song
{
    class Program
    {
        static void SingASong(string title)
        {
            Console.WriteLine($"Let's sing {title}");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("\n\tSong.Program.Main()\n");
            SingASong("Baby Shark!");
        }
    }
}
