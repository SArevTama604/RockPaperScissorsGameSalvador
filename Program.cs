namespace RockPaperScissorsGameSalvador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Rock, Paper, Scissors!");

            String[] options = { "Rock", "Paper", "Scissors" };

            Console.WriteLine("Choose one: Rock, Paper, or Scissors");

            string userChoice = Console.ReadLine();

            Random random = new Random();
            int computerChoiceIndex = random.Next(0, 3);
            string computerChoice = options[computerChoiceIndex];

            Console.WriteLine("The computer chose: " + computerChoice);

            if (userChoice == computerChoice)
            {
                Console.WriteLine("Its's a tie!");
            }
            else if ((userChoice == "Rock" && computerChoice == "Scissors") ||
                    (userChoice == "Paper" && computerChoice == "Rock") ||
                    (userChoice == "Scissors" && computerChoice == "Paper"))
            {
                Console.WriteLine("you win!");
            }
            else
            {
                Console.WriteLine("Computers Win!");
            }

            Console.WriteLine("Thanks for playing!");
        }
    }
}
