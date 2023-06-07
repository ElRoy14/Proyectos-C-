
string [,] chess = new string[8,8];

int v = 7;
int h = 7;

for(int H = 0; H <= h; H++)
{

    for(int V = 0; V <= v; V++)
    {

        chess[H,V] = " [Vacío] ";

    }

}


for(int H = 0; H <= h; H++)
{

    for(int V = 0; V <= v; V++)
    {

        Console.Write(chess[H,V]);

    }

    Console.WriteLine();

}