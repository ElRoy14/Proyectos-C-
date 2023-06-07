
//2- Ingresar una frase no mas de 20 caracteres y usando un for mostrar cuantas vocales tiene. 

string f;

Console.WriteLine("Ingrese una frase de no más de 20 caracteres.");

f = Console.ReadLine();

bool ciclo = false;

while(!ciclo ){

    if(f.Length > 20 | f.Length <= 0){

        Console.Clear();

        Console.WriteLine("Ingrese una frase de no más de 20 caracteres.");

        f = Console.ReadLine();

    }else{

        ciclo  = true;

    };

};

string p = "";

int contador = 0;

for(int x = 0; x < f.Length; x ++ ){

    p = f.Substring(x, 1);

    switch(p){

        case "a":

            contador ++;

        break;

        case "e":

            contador ++;

        break;

        case "i":

            contador ++;

        break;

        case "o":

            contador ++;

        break;

        case "u":

            contador ++;

        break;

        case "A":

            contador ++;

        break;

        case "E":

            contador ++;

        break;

        case "I":

            contador ++;

        break;

        case "O":

            contador ++;

        break;

        case "U":

            contador ++;

        break;

        default:

            //Nadie te quiere.

        break;

    };

};

    Console.Clear();

    Console.WriteLine("La frase " + "'" + f + "'" +  " contiene " + contador + " vocales.");

    Thread.Sleep(7000);
    Console.Clear();
