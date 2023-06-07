//Realice un programa que encuentre la hipotenusa o uno de los catetos de
// un triangulo rectangulo usando el teorema de pitagoras.

int value_1, value_2;

bool opc = false;

string a;

while(!opc){

        Console.Clear();

        Console.WriteLine("¿Qué lado desea encontrar?");

        Console.WriteLine("1 - Hipotenusa.");
        Console.WriteLine("2 - Cateto.");
        Console.WriteLine("3 - Salir.");

        Console.WriteLine("");
        Console.WriteLine("    *");
        Console.WriteLine("    * *");
        Console.WriteLine("    *   *");
        Console.WriteLine("    *     *");
        Console.WriteLine("    *       *");
        Console.WriteLine("a)  *         *     c)");
        Console.WriteLine("    *           *");
        Console.WriteLine("    *             *");
        Console.WriteLine("    *               *");
        Console.WriteLine("    *                 *");
        Console.WriteLine("    * * * * * * * * * * *");
        Console.WriteLine("        b)           ");

        a = Console.ReadLine();

    switch(a){

        case "1": //hipotenusa

            Console.Clear();

            double hipotenusa;

            Console.WriteLine("Ingrese el valor del 1er lados.");

            value_1 = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Ingrese el valor del 2do lados.");

            value_2 = Convert.ToInt32(Console.ReadLine());

            hipotenusa = Math.Sqrt((Math.Pow(value_1, 2) + Math.Pow(value_2, 2)));

            hipotenusa = Math.Round(hipotenusa, 2);

            Console.Clear();

            if(Double.IsNaN(hipotenusa) == true){

                Console.WriteLine("ERROR");
                Console.WriteLine("");
                Console.WriteLine("El resultado es negativo.");

                Console.ReadKey();

            }else{

                Console.WriteLine("El valor de la hipotenusa es " + hipotenusa + ".");

            Console.WriteLine("");
            Console.WriteLine("Presione cualquier tecla para continuar...");

            Console.ReadKey();

            };

            break;

            case "2": //Cateto

            Console.Clear();

            double cateto;

            Console.WriteLine("Ingrese el valor del cateto.");

            value_1 = Convert.ToInt32(Console.ReadLine());

            Console.Clear();

            Console.WriteLine("Ingrese el valor de la hipotenusa.");

            value_2 = Convert.ToInt32(Console.ReadLine());

            cateto = Math.Sqrt((Math.Pow(value_1, 2) - Math.Pow(value_2, 2)));

            cateto = Math.Round(cateto, 2);

            Console.Clear();

            if(Double.IsNaN(cateto) == true){

                Console.WriteLine("ERROR");
                Console.WriteLine("");
                Console.WriteLine("El resultado es negativo.");

                Console.ReadKey();

            }else{

                Console.WriteLine("El valor del cateto es " + cateto + ".");

            Console.WriteLine("");
            Console.WriteLine("Presione cualquier tecla para continuar...");

            Console.ReadKey();

            };

            break;

            case "3":

            Console.Clear();

            opc = true;

            Console.WriteLine("Saliendo...");

            Console.ReadKey();

            break;

            default:

            Console.Clear();

            Console.WriteLine("Ingrese un valor valido.");

            Console.ReadKey();

            break;

};

};
