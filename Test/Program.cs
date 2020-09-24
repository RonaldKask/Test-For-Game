using System;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int randomNumber = rnd.Next(1, 4);

            string UserInput;
            string ComputerInput;

            Console.WriteLine("Do you choose rock, paper or scissors?");
            UserInput = Console.ReadLine().ToLower();

            if (randomNumber == 1)
            {
                ComputerInput = "rock";
            }else if (randomNumber == 2)
            {
                ComputerInput = "paper";
            }else
            {
                ComputerInput = "scissors";
            }


            if (UserInput == ComputerInput)
            {
                Console.WriteLine($"It's a draw! The computer also chose {UserInput}");
            } else if(UserInput == "rock" && ComputerInput == "scissors")
            {
                Console.WriteLine("You won! The computer chose Scissors.");
            }else if (UserInput == "rock" && ComputerInput == "paper")
            {
                Console.WriteLine("You lost! The computer chose Paper.");
            }else if (UserInput == "paper" && ComputerInput == "rock")
            {
                Console.WriteLine("You won! The computer chose Rock.");
            }else if (UserInput == "paper" && ComputerInput == "scissors")
            {
                Console.WriteLine("You lost! The computer chose Scissors");
            }else if (UserInput == "scissors" && ComputerInput == "paper")
            {
                Console.WriteLine("You won! The computer chose Paper.");
            }else if (UserInput == "scissors" && ComputerInput == "rock")
            {
                Console.WriteLine("You lost! The computer chose Rock.");
            }else
            {
                Console.WriteLine("You need to enter either Rock, Paper or Scissors in order to play this game.");
            }


        }
    }
}
