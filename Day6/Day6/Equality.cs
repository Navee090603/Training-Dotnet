using System;


namespace Day6
{
    class Player
    {
        float Score;
        
        public static void Equality()
        {
            Player player01 = new Player();
            Player player02 = new Player();

            player01.Score = 25;
            player02.Score = 25;

            Console.WriteLine($"Equlas : {player01.Score.Equals(player02.Score)}");
            Console.WriteLine($"== : {player01.Score==player02.Score}");
            Console.WriteLine($"CompareTo : {player01.Score.CompareTo(player02.Score)}");

            Console.Read();
            
        }

    }
    class equality
    {
        public static void Main()
        {
            Player.Equality();
        }
    }
}
