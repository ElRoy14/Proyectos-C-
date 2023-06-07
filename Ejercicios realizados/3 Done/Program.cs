
//3 - Programa que realice la sucesion fibonacci de los numeros del 1 
//hasta un numero ingresado por el usuario.

int num;
int y = 1;
int z = 0;
int x = 0;


Console.WriteLine("Ingrese un número en consola.");

num = Convert.ToInt32(Console.ReadLine());

Console.Clear();

for(int f = 0; z <= num; f++){

    x = z;

    z = y;

    y = x + z;

    Console.WriteLine(z);

};
