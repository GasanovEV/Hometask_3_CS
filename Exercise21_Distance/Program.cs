int Ax = 0, Ay = 0, Az = 0; 
int Bx = 0, By = 0, Bz = 0;
double distanse;

GetCordinates(ref Ax, ref Ay, ref Az, ref Bx, ref By, ref Bz);

distanse = Math.Sqrt(Math.Pow(Bx - Ax, 2) + Math.Pow(By - Ay, 2) + Math.Pow(Bz - Az, 2));

Console.WriteLine($"Расстояние между двумя точками A({Ax}, {Ay}, {Az}):B({Bx},{By},{Bz})  составляет {distanse:f2}");

static void GetCordinates  (ref int Ax, ref int Ay, ref int Az, ref int Bx, ref int By, ref int Bz) 
{
while (true)
{
    try
    {
        Console.Clear();
        Console.Write("Введите Ax: ");
        Ax = int.Parse(Console.ReadLine()??"");

        Console.Write("Введите Ay: ");
        Ay = int.Parse(Console.ReadLine()??"");

        Console.Write("Введите Az: ");
        Az = int.Parse(Console.ReadLine()??"");

        Console.Write("Введите Bx: ");
        Bx = int.Parse(Console.ReadLine()??"");

        Console.Write("Введите By");
        By = int.Parse(Console.ReadLine()??"");

        Console.Write("Введите Bz");
        Bz = int.Parse(Console.ReadLine()??"");
break;
    }
    catch (Exception exc)
    {
     Console.WriteLine($"Ошибка ввода координат {exc.Message}");
        return;  
    }
}
}