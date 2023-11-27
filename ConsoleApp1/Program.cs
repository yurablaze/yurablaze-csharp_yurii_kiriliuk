//Обчислення площі паралелограма
Console.WriteLine("Площа паралелограма");

Console.WriteLine("Довжина: ");
double Par1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Висота: ");
double Par2 = Convert.ToDouble(Console.ReadLine());

double solution1 = Par1 * Par2;
Console.WriteLine($"Площа паралелограма = {solution1}");



//Обчислювання площі трикутника за формою герона
Console.WriteLine("Площа трикутника за формою герона");

Console.WriteLine("Довжина а: ");
double Her1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Довжина b: ");
double Her2 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Довжина с: ");
double Her3 = Convert.ToDouble(Console.ReadLine());

double p = (Her1 + Her2 + Her3) / 2;
double solution2 = Math.Sqrt(p * (p - Her1) * (p - Her2) * (p - Her3));

Console.WriteLine($"Площа трикутника за формою герона = {solution2}");



//Обчислювання площі бічної поверхні піраміди
Console.WriteLine("Площа бічної поверхні піраміди");

Console.WriteLine("Довжина бічної грані: ");
double Pir1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Висота піраміди: ");
double Pir2 = Convert.ToDouble(Console.ReadLine());

double solution3 = Pir1 * Math.Sqrt(Pir1 / 2) * (Pir1 / 2) + Pir2 * Pir2;
Console.WriteLine($"Площа бічної поверхні піраміди = {solution3}");



//Обчислювання об'єму піраміди
Console.WriteLine("Об'єм піраміди");

Console.WriteLine("Площа основи піраміди: ");
double Obpir1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Висота піраміди: ");
double Obpir2 = Convert.ToDouble(Console.ReadLine());

double solution4 = (1.0 / 3) * Obpir1 * Obpir2;
Console.WriteLine($"Об'єм піраміди = {solution4}");



//Обчислювання об'єму сфери
Console.WriteLine("Об'єм Сфери");

Console.WriteLine("Радіус сфери: ");
double Sfer = Convert.ToDouble(Console.ReadLine());

double solution5 = (4.0 / 3) * Math.PI * Math.Pow(Sfer, 3);