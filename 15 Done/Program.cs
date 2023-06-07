
//Programa para calcular Potencias, voltajes y corrientes.  P = V * I

double power, voltage, current;

string a;

Console.WriteLine("Que quiere calcular. \n");

Console.WriteLine("1 - Potencia.");
Console.WriteLine("2 - Voltaje.");
Console.WriteLine("3 - Corriente. \n");

a = Console.ReadLine();

Console.Clear();

switch(a)
{

    case "1":

    Console.Write("Ingrese el voltaje: ");

    voltage = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("");

    Console.Write("Ingrese la corriente: ");

    current = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("");

    power  = (voltage * current);

    Console.WriteLine("La potencia es = " + power);

    Console.ReadKey();
    Console.Clear();

    break;

    case "2":

    Console.Write("Ingrese la corriente: ");

    current = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("");

    Console.Write("Ingrese la el vataje: ");

    power = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("");

    voltage = (power / current);

    Console.WriteLine("El volta es = " + voltage);

    Console.ReadKey();
    Console.Clear();

    break;

    case "3":

    Console.Write("Ingrese el voltaje: ");

    voltage = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("");

    Console.Write("Ingrese la el vataje: ");

    power = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("");

    current = (power / voltage);

    Console.WriteLine("La corriente es = " + current);

    Console.ReadKey();
    Console.Clear();

    break;

    default:

    Console.WriteLine("Opción no valida.");
    Console.ReadKey();
    Console.Clear();

    break;

}