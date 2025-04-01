namespace TextRPG;

public class Util
{
    public static void Print(string context, ConsoleColor textColor, int delay = 0)
    {
        Console.ForegroundColor = textColor;
        Console.WriteLine(context);
        Thread.Sleep(delay);
        Console.ResetColor();
    }
        
}