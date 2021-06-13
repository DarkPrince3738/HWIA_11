using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            var worker = Accauntant.AskForBonus(Post.worker, 18);
            var boss = Accauntant.AskForBonus(Post.boss, 20);
            var manager = Accauntant.AskForBonus(Post.manager, 10);
            var programmer = Accauntant.AskForBonus(Post.programmer, 53);
            Console.WriteLine($"{worker}, {boss}, {manager}, {programmer}");
        }
    }
    enum Post
    {
        worker=12,
        boss=22, 
        manager=16,
        programmer=19
    }
    class Accauntant
    {
        public static bool AskForBonus(Post post, int hours)
        {
            if (((int)post) < hours)
            {
                return true;
            }
            return false;
        }
    }
}
