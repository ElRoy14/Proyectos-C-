
/*
Crea un programa en C# que dibuje una circunferencia en pantalla de 360. 
Deberá calcular los radianes teniendo en cuenta la formula de más abajo. 
Dibuje la circunferencia con una separación de 5 posiciones entre cada punto, 
utilice Console.SetCursorPosition. Para calcular el seno y el coseno puede utilizar 
las funciones matemáticas Math.Cos y Math.Sin.
*/

double x, y, radio;

for(int z = 0; z < 360; z++)
{

    radio = z * Math.PI / 180;

    x = 35 + 8 * Math.Cos(radio);
    y = 10 + 8 * Math.Sin(radio);
    
    Console.SetCursorPosition((int)x, (int)y);
    Console.Write("X");

}

Console.SetCursorPosition(1, 20);