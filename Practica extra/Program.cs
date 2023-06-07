
/*
CREAR UN ARREGLO LLAMADO NOTAS, QUE ALMACENE TODAS LAS CALIFICACIONES Y LUEGO CALCULA EL PROMEDIO       
SE DEBE PEDIR AL USUARIO CUANTAS ASIGNATURAS VA A EVALUAR Y ESE VALOR ASIGNARSELO AL ARREGLO.

int asignatures;

double calificacion;
double promedio;

Console.WriteLine("Ingrese cuantas asignaturas va a evaluar.");

asignatures = Convert.ToInt32(Console.ReadLine());

Console.Clear();

double[] notas = new double[asignatures];

for(int x = 0; x <= asignatures - 1; x++)
{
    Console.WriteLine("Ingrese la calificación.");

    calificacion = Convert.ToDouble(Console.ReadLine());

    notas[x] = calificacion;

    Console.Clear();

}

promedio = Math.Round(notas.Average(), 2);

Console.WriteLine("El promedio de las calificaciones del estudiante es " + promedio + ".");

*/

/*
HACER UN ALGORITMO PARA UNA TIENDA ONLINE DE CELULARES SAMSUNG QUE TIENE UNA PROMOCIÓN DE DESCUENTO PARA VENDER AL MAYOR, 
ESTA DEPENDERÁ DEL NÚMERO DE CELULARES QUE SE COMPREN. SI SON MÁS DE DIEZ, SE LES DARÁ UN 10% DE DESCUENTO SOBRE EL TOTAL 
DE LA COMPRA; SI EL NÚMERO DE CELULARES ES MAYOR DE VEINTE, PERO MENOR DE TREINTA, SE LE OTORGA UN 20% DE DESCUENTO; Y SI 
SON MÁS TREINTA CELULARES SE OTORGARÁ UN 40% DE DESCUENTO. EL PRECIO DE CADA CELULAR ES DE RD$55,000.00 (IMPRIMA UNA FACTURA 
PARECIDA A LA QUE HA VISTO EN TIENDAS)
*/

static void descuento_10(int celulares)
{

    double totalCompra = (celulares * 55000);

    double totalOff = totalCompra*(0.10);

    Console.WriteLine("-------R SOLUCIONES-------");
    Console.WriteLine("Articulo  Samsung XCIII");
    Console.WriteLine("Precio    RD$55,000.00");
    Console.WriteLine("Cantidad " + celulares);
    Console.WriteLine("Total compra " + totalCompra);
    Console.WriteLine("Descuento   10%");
    Console.WriteLine("Total " + totalOff);

}

static void descuento_20(int celulares)
{

    double totalCompra = (celulares * 55000);

    double totalOff = totalCompra*(0.20);

    Console.WriteLine("-------R SOLUCIONES-------");
    Console.WriteLine("Articulo  Samsung XCIII");
    Console.WriteLine("Precio    RD$55,000.00");
    Console.WriteLine("Cantidad " + celulares);
    Console.WriteLine("Total compra " + totalCompra);
    Console.WriteLine("Descuento   20%");
    Console.WriteLine("Total " + totalOff);
    
}

static void descuento_40(int celulares)
{

    double totalCompra = (celulares * 55000);

    double totalOff = totalCompra*(0.40);

    Console.WriteLine("-------R SOLUCIONES-------");
    Console.WriteLine("Articulo  Samsung XCIII");
    Console.WriteLine("Precio    RD$55,000.00");
    Console.WriteLine("Cantidad " + celulares);
    Console.WriteLine("Total compra " + totalCompra);
    Console.WriteLine("Descuento   40%");
    Console.WriteLine("Total " + totalOff);
    
}

int cntCelulares;

Console.WriteLine("Ingrese cuantos celulares desea comprar.");

cntCelulares = Convert.ToInt32(Console.ReadLine());

Console.Clear();

if(cntCelulares > 10)
{

    descuento_10(cntCelulares);

};


if(cntCelulares > 20 && cntCelulares < 30)
{

    descuento_20(cntCelulares);

}

if(cntCelulares > 30)
{

    descuento_40(cntCelulares);

}