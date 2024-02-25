//using Lab02;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Lab02
//{
//    internal class MultiplayerGame
//    {
//        static int playerCount = 0;

//        public MultiplayerGame()
//        {
//            AddPlayer();
//        }
//        public static void AddPlayer()
//        {
//            playerCount++;
//        }

//        public static void RemovePlayer()
//        {
//            if (playerCount > 0)
//            {
//                playerCount--;
//            }
//            else
//            {
//                Console.WriteLine("Number of Players are already Zero");
//            }
//        }

//        public static int GetPlayerCount()
//        {
//            return playerCount;
//        }
//    }
//}

//class Program
//{
//    public static void Main(string[] args)
//    {
//        MultiplayerGame player1 = new MultiplayerGame();
//        Console.WriteLine("Number of Players: " + MultiplayerGame.GetPlayerCount());
//        MultiplayerGame player2 = new MultiplayerGame();
//        Console.WriteLine("Number of Players: " + MultiplayerGame.GetPlayerCount());


//    }
//}
