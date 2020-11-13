using System;
using System.Collections.Generic;

namespace EnthusiasticMoose
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
            Console.WriteLine("--------------------------------------------");
            Console.WriteLine();
            MooseSays("Magic Mooseball! Ask any question!");
            MagicMooseAnswer();
            // MooseSays("H I, I'M  E N T H U S I A S T I C !");
            // MooseSays("I really am enthusiastic");
            // CanadaQuestion();
        }
        static void MagicMooseAnswer()
        {
            var answers = new List<string>()
                        {
            "As I see it, yes.",
            "Ask again later.",
            "Better not tell you now.",
            "Cannot predict now.",
            "Concentrate and ask again.",
            "Don’t count on it.",
            "It is certain.",
            "It is decidedly so.",
            "Most likely.",
            "My reply is no.",
            "My sources say no.",
            "Outlook not so good.",
            "Outlook good.",
            "Reply hazy, try again.",
            "Signs point to yes.",
            "Very doubtful.",
            "Without a doubt.",
            "Yes.",
            "Yes – definitely.",
            "You may rely on it."
            };
            Random r = new Random();
            int choice = r.Next(0, 19);
            string question = Console.ReadLine();
            if (question.Length > 0)
            {
                MooseSays($"{answers[choice]}");
                MagicMooseAnswer();
            }
            else
            {

            }
        }
        static void CanadaQuestion()
        {
            bool isTrue = MooseAsks("Is Canada real?");
            if (isTrue)
            {
                MooseSays("Really? It seems very unlikely.");
            }
            else
            {
                MooseSays("I  K N E W  I T !!!");
            }
            EnthusiasticQuestion();

        }
        static void EnthusiasticQuestion()
        {
            bool isEnthusiastic = MooseAsks("Are you enthusiastic?");
            if (isEnthusiastic)
            {
                MooseSays("Yay!");
            }
            else
            {
                MooseSays("You should try it!");
            }
            LoveCSharpQuestion();
        }

        static void LoveCSharpQuestion()
        {
            bool doesLoveCSharp = MooseAsks("Do you love C# yet?");
            if (doesLoveCSharp)
            {
                MooseSays("Good job sucking up to your instructor!");
            }
            else
            {
                MooseSays("You will...oh, yes, you will...");
            }
            SecretQuestion();
        }

        static void SecretQuestion()
        {
            bool isEverythingFine = MooseAsks("Do you want to know a secret?");
            if (isEverythingFine)
            {
                MooseSays("ME TOO!!!! I love secrets...tell me one!");
            }
            else
            {
                MooseSays("Oh, no...secrets are the best, I love to share them!");
            }
        }
        static void MooseSays(string message)
        {
            Console.WriteLine($@"
                                      _.--^^^--,
                                    .'          `\
  .-^^^^^^-.                      .'              |
 /          '.                   /            .-._/
|             `.                |             |
 \              \          .-._ |          _   \
  `^^'-.         \_.-.     \   `          ( \__/
        |             )     '=.       .,   \
       /             (         \     /  \  /
     /`               `\        |   /    `'
     '..-`\        _.-. `\ _.__/   .=.
          |  _    / \  '.-`    `-.'  /
          \_/ |  |   './ _     _  \.'
               '-'    | /       \ |
                      |  .-. .-.  |
                      \ / o| |o \ /
                       |   / \   |    {message}
                      / `^`   `^` \
                     /             \
                    | '._.'         \
                    |  /             |
                     \ |             |
                      ||    _    _   /
                      /|\  (_\  /_) /
                      \ \'._  ` '_.'
                       `^^` `^^^`
    ");
        }
        static bool MooseAsks(string question)
        {
            Console.Write($"{question} (Y/N): ");
            string answer = Console.ReadLine().ToLower();

            while (answer != "y" && answer != "n")
            {
                Console.Write($"{question} (Y/N): ");
                answer = Console.ReadLine().ToLower();
            }

            return answer == "y";
        }
    }
}
