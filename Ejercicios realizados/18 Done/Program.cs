
/*
Escriba un programa en C# que solicite al usuario las notas de 10 alumnos divididos en 2 
grupos de 5 alumnos en cada uno. Deberás almacenarlos en una matriz bidimensional y mostrar 
la medía aritmética de cada grupo de alumnos.
*/

int[,] calif = new int[2,5];
int[] grupo1 = new int[5];
int[] grupo2 = new int[5];

int points;
double promedio1;
double promedio2;

for(int x = 0; x <= 4; x++)
{

    Console.WriteLine("GRUPO #1. \n");

    Console.WriteLine("Ingrese la calificacion del estudiante del GRUPO #1.");

    points = Convert.ToInt32(Console.ReadLine());

    calif[0,x] = points;

    Console.Clear();

}

for(int x = 0; x <= 4; x++)
{

    Console.WriteLine("GRUPO #2. \n");

    Console.WriteLine("Ingrese la calificacion del estudiante del GRUPO #2.");

    points = Convert.ToInt32(Console.ReadLine());

    calif[1,x] = points;

    Console.Clear();

}

for(int x = 0; x <= 4; x++)
{

    grupo1[x] = calif[0,x];

    grupo2[x] = calif[1,x];

}

promedio1 = grupo1.Average();
promedio2 = grupo2.Average();

Console.WriteLine("La media aritemetica del grupo #1 es " + Math.Round(promedio1, 2) + ". \n");

Console.WriteLine("La media aritemetica del grupo #2 es " + Math.Round(promedio2, 2) + ". \n");