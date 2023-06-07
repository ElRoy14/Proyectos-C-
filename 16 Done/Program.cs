
/*Cree un programa en C# que solicite 5 números enteros al usuario para almacenarlos en una matriz 
de números enteros. Después deberá implementar una función llamada Sumar que acepte que parámetro 
un array de enteros. Por último muestre el resultado en pantalla.
*/

int num;

int[] numbers = new int[5];

Console.WriteLine("Ingrese los numeros.");

for(int x = 0; x <= 4; x++)
{

Console.WriteLine("Ingrese el numero.");

num = Convert.ToInt32(Console.ReadLine());

numbers[x] = num;

Console.Clear();

}

sumar(numbers);

static void sumar(int[] numbers)
{

    int suma = numbers.Sum();

    Console.WriteLine("La suma de los numeros ingresados es: " + suma + ".");

    Console.ReadKey();
    Console.Clear();

}