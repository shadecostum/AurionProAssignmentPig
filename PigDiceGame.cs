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


            
            Console.WriteLine("welcome to Pig Dice Game");
            while (true)
            {
               
                int totalTurnScore = 0;
                
                while (true)
                {
                    Random randomNumber = new Random();
                    int currentTurnScore = randomNumber.Next(1, 7);


                    Console.WriteLine(" 1.Type 'r' to ROLL THE Dise,2.Type 'h' to HOLD 3.Type 'q' to Quit the Game ");
                    string diceTurn = Console.ReadLine().ToLower();

                    if (currentTurnScore == 1)
                    {
                        Console.WriteLine("You rolled a :" + currentTurnScore);
                        Console.WriteLine("Sorry you ----- LOSE------ TRY ------AGAIN");
                        totalTurnScore = 0;
                       
                        
                    }
                    else if(diceTurn=="q")
                    {
                        Console.WriteLine("quiting the Game");
                        return;
                        
                    }
                    else if (diceTurn == "r")
                    {
                        totalTurnScore = totalTurnScore + currentTurnScore;
                        Console.WriteLine("current turn score :  " + currentTurnScore);
                        Console.WriteLine("Total score recived : " + totalTurnScore);

                        /*if (currentTurnScore >= 20)
                        {
                            Console.WriteLine("-----YOU_____WIN------ ");
                            //break;
                            return;
                        }*/
                    }
                    else if (diceTurn == "h")
                    {
                        Console.WriteLine("Total score recived :  " + totalTurnScore);
                        if (totalTurnScore >= 20)
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

    