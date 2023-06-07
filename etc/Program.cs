
//Usando ciclo for y arrays haga un programa que pida 5 numeros y evalue cuantos numeros positivos, negativos, pares e impares se introdujeron.


double num;
double z;
int a = 1;

int cont_plus = 0;
int cont_minus = 0;
int cont_p = 0;
int cont_im = 0;

double[] numeros = new double[5];

Console.WriteLine("El programa evaluará cuantos: ");
Console.WriteLine("Numeros positivos se introdujeron.");
Console.WriteLine("Numeros negativos se introdujeron.");
Console.WriteLine("Numeros pares se introdujeron.");
Console.WriteLine("Numeros impares se introdujeron.");
Console.WriteLine("");
Console.WriteLine("Ingrese 5 numeros en consola.");

for(int x = 0; x < numeros.Length; x++ ){

    Console.Write(a + "-" + " ");
    num = Convert.ToDouble(Console.ReadLine());
    numeros[x] = num;

    a++;

};

    for(int x = 0; x < numeros.Length; x++){

        z = numeros[x];

        if(z > 0){

        cont_plus ++;

        };

    };

    for(int x = 0; x < numeros.Length; x++){

        z = numeros[x];

        if(z < 0){

        cont_minus ++;

    };

    };


    for(int x = 0; x < numeros.Length; x++){

        z = numeros[x];

        if((z%2) == 0){

        cont_p ++;

    };

    };

    
    for(int x = 0; x < numeros.Length; x++){

        z = numeros[x];

        if((z%2) != 0){

        cont_im ++;

    };

    };

    Console.ReadKey();
    Console.Clear();


Console.WriteLine("Se introdujeron: ");
Console.WriteLine(cont_plus + " Numeros positivos.");
Console.WriteLine(cont_minus + " Numeros negativo.");
Console.WriteLine(cont_p + " Numeros pares.");
Console.WriteLine(cont_im + " Numeros impares.");

    Console.ReadKey();
    Console.Clear();


        /*

    double num;

    Console.WriteLine("Ingrese un numero en consola.");

    num = Convert.ToDouble(Console.ReadLine());

    if(num > 0){

        Console.WriteLine("Decremento de " + num + " hasta 0.");

        for(int x = 0; num >= x; num --){

            Console.WriteLine(num);

        }

    }else{

        Console.WriteLine("incremento de " + num + " hasta 0.");

        for(int x = 0; num <= x ; num ++){

            Console.WriteLine(num);

        }


    };

    */



