using System;

public class GratitudeActivity : Activity
{
    private string[] _prompts;
    private Random _random;

    public GratitudeActivity()
        : base(
            "Gratitude Activity",
            "This activity will help you focus on the positive things in your life by giving you time to think about and record things you are grateful for."
        )
    {
        _prompts = new string[]
        {
            "What is something you are grateful for today?",
            "Who is someone you are grateful to have in your life?",
            "What is a blessing you have received recently?",
            "What is something about your family that you appreciate?",
            "What is something about your work or education that you appreciate?"
        };

        _random = new Random();
    }

    public void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine("Think about the following:");
        Console.WriteLine();
        Console.WriteLine($"--- {_prompts[_random.Next(_prompts.Length)]} ---");
        Console.WriteLine();

        Console.WriteLine("Take a moment to think...");
        ShowCountDown(5);

        Console.WriteLine();
        Console.WriteLine("Now reflect on your answer.");

        DateTime endTime = DateTime.Now.AddSeconds(GetDuration());

        while (DateTime.Now < endTime)
        {
            ShowSpinner(2);
        }

        Console.WriteLine();
        Console.WriteLine("Take a moment to appreciate what you have.");

        DisplayEndingMessage();
    }
}