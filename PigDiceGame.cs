using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PigDiseGame
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int totalScore = 0;
            Console.WriteLine("welcome to Pig Dice Game");
            while (true)
            {
               
                int currentTurnScore = 0;
                totalScore = 0;
                while (true)
                {
                    Random rn = new Random();
                    int diceRandom = rn.Next(1, 7);


                    Console.WriteLine(" 1.Type 'r' to ROLL THE Dise,2.Type 'h' to HOLD 3.Type 'q' to Quit the Game ");
                    string diceTurn = Console.ReadLine().ToLower();

                    if (diceRandom == 1)
                    {
                        Console.WriteLine("You rolled a :" + diceRandom);
                        Console.WriteLine("Sorry you ----- LOSE------ TRY ------AGAIN");
                        currentTurnScore = 0;
                       
                        
                    }
                    else if(diceTurn=="q")
                    {
                        Console.WriteLine("quiting the Game");
                        return;
                        
                    }
                    else if (diceTurn == "r")
                    {
                        currentTurnScore = currentTurnScore + diceRandom;
                        Console.WriteLine("current turn score :  " + diceRandom);
                        Console.WriteLine("Total score recived : " + currentTurnScore);
                        totalScore = currentTurnScore;
                        if (currentTurnScore >= 20)
                        {
                            Console.WriteLine("-----YOU_____WIN------ ");
                            break;
                        }
                    }
                    else if (diceTurn == "h")
                    {
                        Console.WriteLine("Total score recived :  " + currentTurnScore);
                        if (currentTurnScore >= 20)
                        {
                            Console.WriteLine("-----YOU_____WIN------ ");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("you------ LOSE ----- play again");
                        }

                       
                       
                    }
                    else { Console.WriteLine("-------INVALID ENTRY--------Try r or h "); }

                }
            }
        }  

           
        
    }

}

    