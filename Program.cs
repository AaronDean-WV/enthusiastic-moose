
using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the Enthusiastic Moose Simulator!");
        Console.WriteLine("--------------------------------------------");
        Console.WriteLine();

        // Let the moose speak!
        MooseSays("Ask me a question:");
        // MooseSays("I really am enthusiastic");

        while (true)
        {
            // Console.Write("Ask me a question: ");
            string question = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(question))
                break;

            string response = GetRandomResponse();
            MooseSays(response);
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

    static string GetRandomResponse()
    {
        Random random = new Random();
        string[] responses = {
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
        int index = random.Next(responses.Length);
        return responses[index];
    }
}