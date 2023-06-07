
//Programa en el que el ordenador lanza 50 veces un dado y cuenta cuantas veces sale el nº 1.\

int cont = 0;



for(int x = 1; x <= 50; x++)
{

Random N = new Random();

int num = N.Next(1,6);

switch(num)
{

    case 1:

Console.WriteLine("|¯¯¯¯¯¯¯¯¯¯¯¯¯¯|");
Console.WriteLine("|              |");
Console.WriteLine("|      **      |");
Console.WriteLine("|     *  *     |");
Console.WriteLine("|      **      |");
Console.WriteLine("|              |");
Console.WriteLine("|              |");
Console.WriteLine("¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯");

cont ++;

Thread.Sleep(1*500);
Console.Clear();

    break;

    case 2:

    Console.WriteLine("|¯¯¯¯¯¯¯¯¯¯¯¯¯¯|");
Console.WriteLine("|          **  |");
Console.WriteLine("|         *  * |");
Console.WriteLine("|  **      **  |");
Console.WriteLine("| *  *         |");
Console.WriteLine("|  **          |");
Console.WriteLine("|              |");
Console.WriteLine("¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯");

Thread.Sleep(1*500);
Console.Clear();

    break;

    case 3:

    Console.WriteLine("|¯¯¯¯¯¯¯¯¯¯¯¯¯¯|");
Console.WriteLine("|          **  |");
Console.WriteLine("|      ** *  * |");
Console.WriteLine("|  ** *  * **  |");
Console.WriteLine("| *  * **      |");
Console.WriteLine("|  **          |");
Console.WriteLine("|              |");
Console.WriteLine("¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯");

Thread.Sleep(1*500);
Console.Clear();

    break;

    case 4:

    Console.WriteLine("|¯¯¯¯¯¯¯¯¯¯¯¯¯¯|");
Console.WriteLine("|  **      **  |");
Console.WriteLine("| *  *    *  * |");
Console.WriteLine("|  **      **  |");
Console.WriteLine("|  **      **  |");
Console.WriteLine("| *  *    *  * |");
Console.WriteLine("|  **      **  |");
Console.WriteLine("¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯");

Thread.Sleep(1*500);
Console.Clear();

    break;

    case 5:

    Console.WriteLine("|¯¯¯¯¯¯¯¯¯¯¯¯¯¯|");
Console.WriteLine("|  **      **  |");
Console.WriteLine("| *  * ** *  * |");
Console.WriteLine("|  ** *  *  ** |");
Console.WriteLine("|  **  **  **  |");
Console.WriteLine("| *  *    *  * |");
Console.WriteLine("|  **      **  |");
Console.WriteLine("¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯");

Thread.Sleep(1*500);
Console.Clear();

    break;

    case 6:

    Console.WriteLine("|¯¯¯¯¯¯¯¯¯¯¯¯¯¯|");
Console.WriteLine("|  **  **  **  |");
Console.WriteLine("| *  **  **  * |");
Console.WriteLine("|  **  **  **  |");
Console.WriteLine("|  **  **  **  |");
Console.WriteLine("| *  **  **  * |");
Console.WriteLine("|  **  **  **  |");
Console.WriteLine("¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯¯");

Thread.Sleep(1*500);
Console.Clear();

    break;

}

}

Console.WriteLine("El 1 salió " + cont + " veces.");
