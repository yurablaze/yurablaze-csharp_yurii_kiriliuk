using System.Text;

Console.OutputEncoding = UTF8Encoding.UTF8;
Console.WriteLine(@"1 - Обчислення площі паралелограма
2 - Обчислювання площі трикутника за формою герона
3 - Обчислювання площі бічної поверхні піраміди
4 - Обчислювання об'єму піраміди
5 - Обчислювання об'єму сфери");

Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("Виберіть варіант...");
Console.ResetColor();
string variant = Console.ReadLine();
switch (variant)
{
    case "1":
        Console.WriteLine("Площа паралелограма");

        Console.WriteLine("Довжина: ");
        double lenght_par = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Висота: ");
        double height_par = Convert.ToDouble(Console.ReadLine());

        double solution1 = lenght_par * height_par;
        Console.WriteLine($"Площа паралелограма = {solution1}");
        break;

    case "2":
        Console.WriteLine("Площа трикутника за формою герона");

        Console.WriteLine("Довжина а: ");
        double lenght_a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Довжина b: ");
        double lenght_b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Довжина с: ");
        double lenght_c = Convert.ToDouble(Console.ReadLine());

        double p = (lenght_a + lenght_b + lenght_c) / 2;
        double solution2 = Math.Sqrt(p * (p - lenght_a) * (p - lenght_b) * (p - lenght_c));

        Console.WriteLine($"Площа трикутника за формою герона = {solution2}");
        break;

    case "3":
        Console.WriteLine("Площа бічної поверхні піраміди");

        Console.WriteLine("Довжина бічної грані: ");
        double lenght_pir = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Висота піраміди: ");
        double height_pir = Convert.ToDouble(Console.ReadLine());

        double solution3 = lenght_pir * Math.Sqrt(lenght_pir / 2) * (lenght_pir / 2) + height_pir * height_pir;
        Console.WriteLine($"Площа бічної поверхні піраміди = {solution3}");
        break;

    case "4":
        Console.WriteLine("Об'єм піраміди");

        Console.WriteLine("Площа основи піраміди: ");
        double area = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Висота піраміди: ");
        double height_amount = Convert.ToDouble(Console.ReadLine());

        double solution4 = (1.0 / 3) * area * height_amount;
        Console.WriteLine($"Об'єм піраміди = {solution4}");

        break;

    case "5":
        Console.WriteLine("Об'єм Сфери");

        Console.WriteLine("Радіус сфери: ");
        double sphere = Convert.ToDouble(Console.ReadLine());

        double solution5 = (4.0 / 3) * Math.PI * Math.Pow(sphere, 3);
        break;
}
