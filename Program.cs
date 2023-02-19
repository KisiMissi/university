class Program
{
    private static Utils Utils = new Utils();
    private static Operation Operation = new Operation();
    private static int num1 , num2 = 0;

    public static void Main(String[] args)
    {
        string taskNumber = "";
        Console.Write("Wich task [1]/[2]/[3]/[4]/[5]: ");
        try { taskNumber = Console.ReadLine(); } 
        catch (IOException ex) { Console.WriteLine(ex.Message); }
        

        switch (taskNumber)
        {
            case "1":
                firstTask();
                break;
            case "2":
                secondTask();
                break;
            case "3":
                thirdTask();
                break;
            case "4":
                fourthTask();
                break;
            case "5":
                fifthTask();
                break;
        }
    }

    private static void firstTask()
    {
        try
        {
            Console.Write("Enter first number: ");
            num1 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            num2 = Int32.Parse(Console.ReadLine());
        }
        catch (IOException ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine($"The greaters number of {num1} and {num2} is {Utils.Greater(num1, num2)}");
    }

    private static void secondTask()
    {
        try
        {
            Console.Write("Enter first number: ");
            num1 = Int32.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            num2 = Int32.Parse(Console.ReadLine());

        }
        catch (IOException ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine("Swap of veriables values: \nNum 1 = {0}, Num = {1}", num1, num2);
        Utils.Swap(ref num1, ref num2);
        Console.WriteLine($"Num 1 = {num1}, Num 2 = {num2}");
    }

    private static void thirdTask()
    {
        Console.Write("Enter number of factorial: ");
        int num = 0, fac = 0;
        try
        {
            num = int.Parse(Console.ReadLine());
        }
        catch (IOException ex)
        {
            Console.WriteLine(ex.Message);
        }

        if (Utils.Factorila(num, out fac))
        {
            Console.WriteLine($"{num}! = {fac}");
        }
    }

    private static void fourthTask()
    {
        string wichTriangle = "";
        Console.Write("Is triangle equitateral [Y]/[N]: ");
        try
        {
            // Определяем равносторонний ли треугольник
            wichTriangle = Console.ReadLine();
            if (wichTriangle == "Y" || wichTriangle == "y")
            {
                // Получаем значене одной стороны
                Console.Write("Enter side of triangle: ");
                int side = Int32.Parse(Console.ReadLine());


                Console.WriteLine($"Triangle area = {Operation.HeronFormula(side):F4}");
            }
            else if (wichTriangle == "N" || wichTriangle == "n")
            {
                // Получаем значение всех трех сторон
                Console.Write("Enter first side of triangle: ");
                int side1 = Int32.Parse(Console.ReadLine());
                Console.Write("Enter second side of triangle: ");
                int side2 = Int32.Parse(Console.ReadLine());
                Console.Write("Enter third side of triangle: ");
                int side3 = Int32.Parse(Console.ReadLine());

                double triagleS = Operation.HeronFormula(side1, side2, side3);
                if (triagleS == 0)
                {
                    Console.WriteLine("This triangle doesn't exist");
                }
                else
                {
                    Console.WriteLine($"Triangle area = {triagleS:F4}");
                }
            }

        }
        catch (IOException ex) { Console.WriteLine(ex.Message); }

    }

    private static void fifthTask()
    {
        double x1 = 0, x2 = 0;
        int a = 0, b = 0, c = 0;

        try
        {
            Console.Write("Enter A coefficient: ");
            a = Int32.Parse(Console.ReadLine());
            Console.Write("Enter B coefficient: ");
            b = Int32.Parse(Console.ReadLine());
            Console.Write("Enter C coefficient: ");
            c = Int32.Parse(Console.ReadLine());
        }
        catch (IOException ex) { Console.WriteLine(ex.Message); }

        int answ = Operation.RootExistence(a, b, c, out x1, out x2);

        Console.WriteLine($"A quadratic equation with coefficients: {a}, {b}, {c}");
        if (answ == 1)
        {
            Console.WriteLine($"Has roots: {x1}, {x2}");
        }
        else if (answ == 0)
        {
            Console.WriteLine($"Has root: {x1}");
        } 
        else
        {
            Console.WriteLine("Has no roots");
        }
    }
}