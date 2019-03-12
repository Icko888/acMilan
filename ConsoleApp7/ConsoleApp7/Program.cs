using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    class Program
    {
        class Player
        {
            public string FirstName;
            public string LastName;
            public int FinalScore;

            public string FullName()
            {
                return this.FirstName +" " + this.LastName;
            }

           public Player () { }

            public Player(string firstname,string lastname,int finalscore)
            {
                this.FirstName = firstname;
                this.LastName = lastname;
                this.FinalScore = finalscore;
                     
            }
            public void PrintPlayer1(Player p1)
            {
                Console.WriteLine($"First Name: {FirstName} Last Name: {LastName} Final Score: {FinalScore}");
            }

            public void PrintPlayer2(Player p2)
            {
                Console.WriteLine($"First Name: {FirstName} Last Name: {LastName} Final Score: {FinalScore}");
            }
        }
        

        class Dice
        {
            
            public int Value;
            public int Value2;

            public Dice() { }

            public void Roll()
            {
                Random random = new Random();
                this.Value = random.Next(1,7);
                this.Value2 = random.Next(1, 7);
                     
            }


            public void PrintDice1(Dice dice1)
            {
                Console.WriteLine($"The Value of Dice 1 is: {Value}");
            }

            public void PrintDice2(Dice dice2)
            {
                Console.WriteLine($"The Value of Dice 2 is: {Value2}");
            }
        }

        class Game
        {
            public int WinningScore;
            public string ActivePlayer;
            public int TurnScore;
            public bool GameActive;

            private Player[] players = new Player[2];
            private Dice[] dices = new Dice[2];

            public void StartGame()
            {
               
            }

            private void CreatePlayers()
            {
                for(int i = 0; i < players.Length; i++)
                {
                    Console.WriteLine($"Player{i} First Name:");
                    string firstname = Console.ReadLine();
                    Console.WriteLine($"Player{i} Last Name:");
                    string lastname = Console.ReadLine();
                    
                }
            }

            private void CreateDice()
            {

            }

        }

        static void Main(string[] args)
        {
           
                switch ()
            {
                case 1:
                    Game myGame = new Game();
                    myGame.StartGame();
                    break;
                case 2:
                    
                   
                    break;

            }
           
            


            //Player p1 = new Player();
            //p1.FirstName = "Riste";
            //p1.LastName = "Arsov";
            //p1.FinalScore = 50;
            //p1.PrintPlayer1(p1);
            

            //Player p2 = new Player();
            //p2.FirstName = "Jane";
            //p2.LastName = "Kostov";
            //p2.FinalScore = 50;
            //p2.PrintPlayer2(p2);
            

            //Dice dice1 = new Dice();
            //dice1.Roll();
            //dice1.PrintDice1(dice1);

            //Dice dice2 = new Dice();
            //dice2.Roll();
            //dice2.PrintDice2(dice2);

            Console.ReadLine();
        }
    }
}
