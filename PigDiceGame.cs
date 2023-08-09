using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PigDiseGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
  
            Console.WriteLine("welcome to Pig Dice Game");
            int numberTurn = 1;
            int currentScore = 0;
            int totalScore = 0;
            int holdScore = 0;
            while (true)
            {
                Random randomNumber = new Random();

                Console.WriteLine($"---------------Turn :{numberTurn}--------------");
                while (true)
                {
                    Console.WriteLine("---- 1.Type 'r' to ROLL THE Dise,2.Type 'h' to HOLD ----");
                    string chooseOption = Console.ReadLine().ToLower();

                    if (chooseOption == "r") 
                    {
                        int turnScore = randomNumber.Next(1, 7);
                        if (turnScore == 1)
                        {
                            Console.WriteLine("You rolled a :" + turnScore);
                            Console.WriteLine("Sorry you ----- LOSE------ TRY ------AGAIN");
                            //totalTurnScore = 0;
                            totalScore = 0;
                            currentScore = 0;
                            holdScore = 0;
                            numberTurn++;
                            break;

                        }

                        Console.WriteLine(" You Rolled :  " + turnScore);
                        currentScore =currentScore+ turnScore;
                        holdScore = holdScore + turnScore;
                        if (holdScore >= 20)
                        {
                            Console.WriteLine($" Your Turn Score : {currentScore} ,  Total Score is : {holdScore}");
                            Console.WriteLine("-----------YOU WIN-----------");
                            Console.WriteLine($"You finished in : {numberTurn} TURNS"  );
                            Console.WriteLine("------GAME OVER---------");
                            return;
                        }
                        Console.WriteLine($"  Your Turn Score : {currentScore} ,  Total score recived : {totalScore} ");
                        Console.WriteLine($"If you hold, you will have {holdScore} ");
                        
                    }
                    else if (chooseOption == "h")
                    { 
                        
                        totalScore =totalScore+ currentScore;
                        Console.WriteLine($"  your Turn score recived : {holdScore} and Your Total Score {totalScore}"  );                      
                        currentScore = 0;
                        numberTurn++;
                        break;
  
                    }
                    else { Console.WriteLine("-------INVALID ENTRY--------Try 'r' or 'h' "); }
                    

                }
                

            }
        }  
   
    }

}

    