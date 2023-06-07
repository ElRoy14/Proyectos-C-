
int d, m, y;

int nd, nm, ny;

Console.WriteLine("Ingrese el dia.");

d = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese el mes.");

m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese el año.");

y = Convert.ToInt32(Console.ReadLine());

Console.Clear();

switch(m)
{

    case 1:

    if(d == 31)
    {

        Console.WriteLine(01 + "/" + (m + 1) + "/" + y);

    }else{

        Console.WriteLine(d + "/" + m + "/" + y + "-->" + d + 1 + "/" + m + "/" + y );

    }


    break;

    case 2:

    if(d == 29 | d > 29)
    {

        Console.WriteLine(01 + "/" + (m + 1) + "/" + y);

    }else{

        Console.WriteLine(d + "/" + m + "/" + y + "-->" + d + 1 + "/" + m + "/" + y );

    }

    break;

    case 3:

    if(d == 31)
    {

        Console.WriteLine(01 + "/" + (m + 1) + "/" + y);

    }else{

        Console.WriteLine(d + "/" + m + "/" + y + "-->" + d + 1 + "/" + m + "/" + y );

    }

    break;

    case 4:

    if(d == 30 | d > 30)
    {

        Console.WriteLine(01 + "/" + (m + 1) + "/" + y);

    }else{

        Console.WriteLine(d + "/" + m + "/" + y + "-->" + d + 1 + "/" + m + "/" + y );

    }


    break;

    case 5:

    if(d == 31)
    {

        Console.WriteLine(01 + "/" + (m + 1) + "/" + y);

    }else{

        Console.WriteLine(d + "/" + m + "/" + y + "-->" + d + 1 + "/" + m + "/" + y );

    }


    break;

    case 6:

    if(d == 30 | d > 30)
    {

        Console.WriteLine(01 + "/" + (m + 1) + "/" + y);

    }else{

        Console.WriteLine(d + "/" + m + "/" + y + "-->" + d + 1 + "/" + m + "/" + y );

    }


    break;

    case 7:

    if(d == 31)
    {

        Console.WriteLine(01 + "/" + (m + 1) + "/" + y);

    }else{

        Console.WriteLine(d + "/" + m + "/" + y + "-->" + d + 1 + "/" + m + "/" + y );

    }


    break;

    case 8:

    if(d == 31)
    {

        Console.WriteLine(01 + "/" + (m + 1) + "/" + y);

    }else{

        Console.WriteLine(d + "/" + m + "/" + y + "-->" + d + 1 + "/" + m + "/" + y );

    }


    break;

    case 9:

    if(d == 30 | d > 30)
    {

        Console.WriteLine(01 + "/" + (m + 1) + "/" + y);

    }else{

        Console.WriteLine(d + "/" + m + "/" + y + "-->" + d + 1 + "/" + m + "/" + y );

    }


    break;

    case 10:

    if(d == 31)
    {

        Console.WriteLine(01 + "/" + (m + 1) + "/" + y);

    }else{

        Console.WriteLine(d + "/" + m + "/" + y + "-->" + d + 1 + "/" + m + "/" + y );

    }


    break;

    case 11:

    if(d == 30 | d > 30)
    {

        Console.WriteLine(01 + "/" + (m + 1) + "/" + y);

    }else{

        Console.WriteLine(d + "/" + m + "/" + y + "-->" + d + 1 + "/" + m + "/" + y );

    }


    break;

    case 12:

    if(d == 31)
    {

        Console.WriteLine(01 + "/" + 01 + "/" + y + 1);

    }else{

        Console.WriteLine(d + "/" + m + "/" + y + "-->" + 01 + "/" + 01 + "/" + (y + 1) );

    }


    break;

}