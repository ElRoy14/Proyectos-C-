
//e ingresa por teclado la cantidad de agua caida, en mílimetros día a día durante un mes.
//Se pide determinar el día de mayor lluvia, el de menor y el promedio.

double rain;

double[] rain_Days = new double[30];

Console.WriteLine("Ingrese en mililitros la cantidad de agua caida en un mes.");

for(int x = 0; x <= 29; x++)
{

    rain = Convert.ToDouble(Console.ReadLine());

    rain_Days[x] = rain;

    Console.Clear();

}

double maxDay = rain_Days.Max();

int dayMax = Array.IndexOf(rain_Days, maxDay);

double minDay = rain_Days.Min();

int dayMin = Array.IndexOf(rain_Days, minDay);

double average = Math.Round(rain_Days.Average(), 2);

Console.WriteLine("Durante el mes el día que más agua cayó fué: " + (dayMax + 1) + ".");

Console.WriteLine("Durante el mes el día que menos agua cayó fué: " + (dayMin + 1) + ".");

Console.WriteLine("El promedio de agua caida fué: " + (average + 1) + " mL.");