
string[] animals = new string[]
{

    "Calamar",	
    "Foca",	
    "Delfín",
    "Pez león",
    "León Marino",	
    "Cachalote",
    "Ballena franca",	
    "Ancistrus común",	
    "Ballena azul",
    "Anguila eléctrica",
    "Medusa",	
    "Ballena gris",
    "Pepino de mar",	
    "Sepia",	
    "Tiburón ballena",
    "Sardinas",	
    "Gamba",	
    "Calderón común",
    "Manatí",	
    "Trucha común",	
    "Cíclico nacarado",
    "Pulpo",	
    "Pulpo de anillos azules",	
    "Tetra de Aleta Sangrante",
    "Pez arquero",	
    "Pez cola de espada",	
    "Caracol de mar",
    "Pez sapo peludo",	
    "Pez luna",	
    "Tiburón blanco"

};

string str;

Console.WriteLine("Escriba el nombre del animal que busca.");

str = Console.ReadLine();

foreach(string animal in animals)
{

    if(str == animal)
    {

        Console.WriteLine(animal);

    }

}
