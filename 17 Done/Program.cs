
/*
Cree un programa en C# que solicite al usuario su nombre y su edad. 
Debe almacenarlos en una estructura de datos struct y luego saludar 
al usuario utilizando su nombre.
*/


    Console.WriteLine("Ingrese su nombre.");

    string X = Console.ReadLine();

    Console.WriteLine("Ingrese su edad.");

    int Y = Convert.ToInt32(Console.ReadLine());

    var info = new data(X, Y);

    Console.WriteLine(info);



public struct data
{

    public data(string name, int age)
    {

        nombre =  name;
        edad =  age;

    }

    public string nombre { get; init; }
    public int edad { get; init; }

    public override string ToString() => $"Hola " + nombre;


}
