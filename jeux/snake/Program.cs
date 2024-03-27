namespace snake;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        origRow = Console.CursorTop;
        origCol = Console.CursorLeft;

        WriteAt("+", 0, 0);
        WriteAt("|", 0, 1);
        WriteAt("|", 0, 2);
        WriteAt("|", 0, 3);
        WriteAt("+", 0, 4);
    }
}
