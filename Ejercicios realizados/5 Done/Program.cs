
/*
Crea un programa en C# que solicite al usuario 5 números enteros y muestre en pantalla las siguientes estadísticas matemáticas:

La suma de los 5 números
La media aritmética
El número máximo
El número mínimo

*/

int[] numeros = new int[5];

int num, m;
int z  = 0;
int cont = 0;

for(int x = 0; x < numeros.Length; x++){

    Console.Clear();

    Console.WriteLine("Ingrese un número en consola.");

    num = Convert.ToInt32(Console.ReadLine());

    numeros[x] = num;

};

for(int x = 0; x < numeros.Length; x++){

    z = numeros[x] + z;

};

foreach(int n in numeros){

    foreach(int f in numeros){

        if(n == f){

            cont ++;

        };

    };

};

Console.WriteLine(cont);

