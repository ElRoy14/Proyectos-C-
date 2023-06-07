
//1 - Dados 3 números donde el primero y el último son límites de un intervalo, indicar si el tercero pertenece a dicho intervalo.

int num_1, num_2, num_3;

Console.WriteLine("Ingrese el primer número.");

num_1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese el segundo número.");

num_2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese el tercer número.");

num_3 = Convert.ToInt32(Console.ReadLine());


Console.Clear();

if(num_1 > num_2){

    if(num_3 < num_1 && num_3 > num_2){

        Console.WriteLine("El número " + num_3 + " está entre " + num_2 + " y " + num_1 + ".");

    }else{

        Console.WriteLine("El número " + num_3 + " no está entre " + num_2 + " y " + num_1 + ".");

    };

}else{

    if(num_3 > num_1 && num_3 < num_2){

        Console.WriteLine("El número " + num_3 + " está entre " + num_1 + " y " + num_2 + ".");

    }else{

        Console.WriteLine("El número " + num_3 + " no está entre " + num_1 + " y " + num_2 + ".");

    };

};

Console.ReadKey();