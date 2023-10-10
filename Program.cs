namespace pianino;

internal class Program
{
    static void Main()
    {
        int[] oktava = Octave(1);
        Console.WriteLine("Нажмите f1 или f2,чтобы сменить октаву");
        Console.WriteLine("Октава 1");

        while (true)
        {
            ConsoleKeyInfo keyboard = Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Green;
            if (keyboard.Key == ConsoleKey.Q)
            {
                Console.Beep(oktava[0], 500);
            }
            else if (keyboard.Key == ConsoleKey.W)
            {
                Console.Beep(oktava[1], 500);
            }
            else if (keyboard.Key == ConsoleKey.E)
            {
                Console.Beep(oktava[2], 500);
            }
            else if (keyboard.Key == ConsoleKey.R)
            {
                Console.Beep(oktava[3], 500);
            }
            else if (keyboard.Key == ConsoleKey.T)
            {
                Console.Beep(oktava[4], 500);
            }
            else if (keyboard.Key == ConsoleKey.Y)
            {
                Console.Beep(oktava[5], 500);
            }
            else if (keyboard.Key == ConsoleKey.U)
            {
                Console.Beep(oktava[6], 500);
            }
            else if (keyboard.Key == ConsoleKey.I)
            {
                Console.Beep(oktava[7], 500);
            }
            else if (keyboard.Key == ConsoleKey.O)
            {
                Console.Beep(oktava[8], 500);
            }
            else if (keyboard.Key == ConsoleKey.P)
            {
                Console.Beep(oktava[9], 500);
            }
            else if (keyboard.Key == ConsoleKey.A)
            {
                Console.Beep(oktava[10], 500);
            }
            else if (keyboard.Key == ConsoleKey.S)
            {
                Console.Beep(oktava[11], 500);
            }
            else if (keyboard.Key == ConsoleKey.F1)
            {
                oktava = Octave(1);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Нажмите f1 или f2,чтобы сменить октаву");
                Console.WriteLine("Октава 1");

            }
            else if (keyboard.Key == ConsoleKey.F2)
            {
                oktava = Octave(2);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Нажмите f1 или f2,чтобы сменить октаву");
                Console.WriteLine("Октава 2");

            }
        }
}

    static int[] Octave(int oct)
    {
        int[] octave = { 262, 277, 294, 311, 330, 349, 370, 392, 415, 440, 466, 493 };
        int[] octave2 = { 523, 544, 587, 622, 659, 699, 740, 784, 831, 880, 932, 988, };

        if (oct == 1)
        {
            return octave;
        }
        else
        {
            return octave2;
        }
    }
}
