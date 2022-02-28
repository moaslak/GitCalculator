namespace GitCalculator;

public class menuClass
{
    double Tal1;
    double Tal2;
    public menuClass()
    {
        int operation = 0;
        Calc calc = new Calc();
        Console.Write("Select mode: ");

        Int32.TryParse(Console.ReadLine(), out operation);
        switch (operation)
        {
            case 1:
                Console.Write("Input Tal1: ");
                double.TryParse(Console.ReadLine(), out Tal1);
                Console.Write("Input Tal2: ");
                double.TryParse(Console.ReadLine(), out Tal2);

                Console.WriteLine(calc.plus(Tal1, Tal2).ToString());
                break;
            case 2:
                Console.Write("Input Tal1: ");
                double.TryParse(Console.ReadLine(), out Tal1);
                Console.Write("Input Tal2: ");
                double.TryParse(Console.ReadLine(), out Tal2);

                Console.WriteLine(calc.minus(Tal1, Tal2).ToString());
                break;
            case 3:
                Console.Write("Input Tal1: ");
                double.TryParse(Console.ReadLine(), out Tal1);
                Console.Write("Input Tal2: ");
                double.TryParse(Console.ReadLine(), out Tal2);

                Console.WriteLine(calc.multiply(Tal1, Tal2).ToString());

                break;
            case 4:
                Console.Write("Input Tal1: ");
                double.TryParse(Console.ReadLine(), out Tal1);
                Console.Write("Input Tal2: ");
                double.TryParse(Console.ReadLine(), out Tal2);

                Console.WriteLine(calc.div(Tal1, Tal2).ToString());
                break;
            default:
                Console.WriteLine("1, 2, 3, 4");
                break;
        }
    }

}