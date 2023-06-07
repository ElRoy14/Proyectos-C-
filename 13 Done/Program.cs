
// Realizar   un  programa  que   calcule   e  imprima   la   suma   de  los   múltiplos  de  5 comprendidos entra dos valores a y b .

bool c = false;

int a, b, i, r;

Console.WriteLine("Ingrese el valor de a.");

a = Convert.ToInt32(Console.ReadLine());

while(!c)
{

    if(a < 0)
    {

        Console.WriteLine("Ingrese el valor de a.");

        a = Convert.ToInt32(Console.ReadLine());

    }else
    {

        c= true;

    }

}

c = false;

Console.WriteLine("Ingrese el valor de b.");

b = Convert.ToInt32(Console.ReadLine());

while(!c)
{

    if(b < 0)
    {

        Console.WriteLine("Ingrese el valor de b.");

        b = Convert.ToInt32(Console.ReadLine());

    }else
    {

        c= true;

    }

}

if(a > b)
{

    i = a;

    a = b;

    b = i;

}

int dif = b - a;

int cont = 0;

for(int x = a; x <= b; x++ )
{

        if((x%5) == 0)
        {

            cont ++;

        }

}

int[] num = new int[cont];

int v = 0;

for(int x = a; x <= b; x++ )
{

            for(int z = v; z <= num.Length -1; z++ )
            {

                if((x%5) == 0)
                {

                    num[v] = x;
                    v++;
                    break;

                }

            }

}

Console.Clear();

r = num.Sum();

Console.Write("La suma de los multiplos de 5 entre " + a + " y " + b + " es: ");

Console.WriteLine(r);