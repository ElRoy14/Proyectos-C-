
//Realizar programa en el que el ordenador “piensa” en un número al azar entre 1 y 50.   
//El ordenador señalará si es mayor o menor.
//El usuario ha de adivinarlo en 5 oportunidades.

int num;
int intentos = 5;

bool loop = false;

Random rnd = new Random();
int ran = rnd.Next(1,50);

for(int y = 0; y <= 15; y ++){

    Console.Clear();
    Console.WriteLine("Generando número aleatorio.");
    Thread.Sleep(200);
    Console.Write(ran = rnd.Next(1,50));
    Thread.Sleep(150);
    Console.Clear();
    Console.WriteLine("Generando número aleatorio..");
    Thread.Sleep(200);
    Console.Write(ran = rnd.Next(1,50));
    Thread.Sleep(150);
    Console.Clear();
    Console.WriteLine("Generando número aleatorio...");
    Thread.Sleep(200);
    Console.Write(ran = rnd.Next(1,50));
    Thread.Sleep(150);

}

Console.Clear();

ran = rnd.Next(1,50);

Console.WriteLine("Intente adivinar el número entre 1 y 50.");

num = Convert.ToInt32(Console.ReadLine());

    while(!loop){

        if(num > 0 && num < 51){

            loop = true;

        }else{

            Console.Clear();

            Console.WriteLine("Ingrese un número entre 1 y 50.");

            num = Convert.ToInt32(Console.ReadLine());
            
        };

    };

for(int x = 0; x <= 4; x ++){

    if(num < ran){

        Console.Clear();

        intentos --;

        Console.WriteLine("El número es mayor que " + num + ".");
        Console.WriteLine("");
        Console.WriteLine("Intentelo de nuevo.");
        Console.WriteLine("");
        Console.WriteLine("Te quedan " + intentos + "/5 intentos.");

        num = Convert.ToInt32(Console.ReadLine());

    }else{

        Console.Clear();

        intentos --;

        Console.WriteLine("El número es menor que " + num + ".");
        Console.WriteLine("");
        Console.WriteLine("Intentelo de nuevo.");
        Console.WriteLine("");
        Console.WriteLine("Te quedan " + intentos + "/5 intentos.");

        num = Convert.ToInt32(Console.ReadLine());

    };

    if(num == ran){

        Console.Clear();

        Console.WriteLine("**Felicidades fenomeno de alguna forma adivinaste.**");

        x = 5;

        Console.ReadKey();

    };

};

if(num != ran){

    Console.WriteLine("Lo siento, te quedaste sin intentos sigue será la proxima.");

Console.ReadKey();

};