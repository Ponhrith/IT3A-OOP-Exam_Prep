using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson06Ex1
{
    class Player
    {
        public string strName;
        public int intScore;
        private static int intTotalPlayer;
        private static int intTotalScore;
        public static int TotalPlayer()
        {
            return Player.intTotalPlayer;
        }
        public static int TotalScore()
        {
            return Player.intTotalScore;
        }

        public Player(string strName, int intScore)
        {
            this.strName = strName;
            this.intScore = intScore;
            intTotalPlayer++;
            intTotalScore = intScore + intTotalScore;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Player objPlayer1, objPlayer2;
            Console.WriteLine("Enter the name for player 1: ");
            string strName = Console.ReadLine();
            Console.WriteLine("Enter the score for player 1: ");
            int intScore = int.Parse(Console.ReadLine());
            objPlayer1 = new Player(strName, intScore);

            Console.WriteLine("Enter the name for player 2: ");
            strName = Console.ReadLine();
            Console.WriteLine("Enter the score for player 2: ");
            intScore = int.Parse(Console.ReadLine());
            objPlayer2 = new Player(strName, intScore);

            Console.WriteLine("Player 1 Name: {0} Score: {1}",
                objPlayer1.strName, objPlayer1.intScore);
            Console.WriteLine("Player 2 Name: {0} Score: {1}",
                objPlayer2.strName, objPlayer2.intScore);
            Console.WriteLine("Total number of player = {0}", Player.TotalPlayer());
            Console.WriteLine("Total number of score = {0}.", Player.TotalScore());
        }
    }
}
