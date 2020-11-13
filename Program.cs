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
            MooseQuestion(0);
            MooseSays("Hi, I'm  Enthusiastic!!");
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
            Console.WriteLine("Ask your question(no input to end):");
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
        static void MooseQuestion(int question)
        {
            var questions = new List<string>()
            {
                "Is Canada real?",
                "Are you enthusiastic?",
                "Do you love C# yet?",
                "Do you want to know a secret?"
            };
            var falseAnswers = new List<string>()
            {
                "I  K N E W  I T !!!",
                "You should try it!",
                "You will...oh, yes, you will...",
               "Oh, no...secrets are the best, I love to share them!"
            };
            var trueAnswers = new List<string>()
            {
                "Really? It seems very unlikely.",
                "Yay!",
                "Good job sucking up to your instructor!",
                "ME TOO!!!! I love secrets...tell me one!"
            };
            bool isTrue = MooseAsks(questions[question]);
            string response = isTrue ? trueAnswers[question] : falseAnswers[question];
            MooseSays(response);
            question++;
            int length = questions.Count - 1;
            if (question <= length)
            {
                MooseQuestion(question);
            }
            else
            {
                MooseSays("Magic Mooseball! Ask any question!");
                MagicMooseAnswer();
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
