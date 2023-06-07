
//Escriba un programa en C# que solicite un símbolo y un ancho que utilizará para dibujar el cuadrado hueco de ese ancho y alto.


char v;

int i;

Console.WriteLine("Ingrese un caracter en consola.");

v = Convert.ToChar(Console.ReadLine());

Console.WriteLine("Ingrese el ancho del cuadrado.");

i = Convert.ToInt32(Console.ReadLine());

for(int x = 0; x <= i; x++)
{

    if(x == 0)
    {

        for(int z = 1; z <= i; z ++ )
        {

            Console.Write(v);

        }

    };

    if( x > 0 && x < i)
    {

        for(int p = 0; p <= i; p++)
        {

            if(p == 0)
            {

                Console.Write(v);

            }

            if( p > 0 && p < i)
            {

                Console.Write(" ");

            }

            if(p == i)
            {

                Console.WriteLine(v);

            }

        }

    }

    if(x == i)
    {

        for(int z = 1; z <= i + 1; z ++ )
        {

            Console.Write(v);

        }

    };

}