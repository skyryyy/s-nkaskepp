using System;

namespace battleship
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aiship = new Random();

            Random aishot = new Random();   //Genererar slumpsiffror för att datorn ska skjuta och lägga ut skepp

            string restart = "";

            while (restart == "")    //Loop för att kunna starta om eller stänga av
            {
                int hpyou = 5;

                int hpai = 5;   //Värden så att jag kan stänga ner den senare loopen

                Console.WriteLine("This is a mini version of battleship");

                Console.WriteLine("You will be asked to place 5 1x1 ships in a 10x5 grid");

                Console.WriteLine("The A.I will then place five ships at random and the you duke it out til one stand left");

                Console.WriteLine("Place your ships (place by typing x coord 1-5, then y coord 1-5 ex. 53)");   //Bara massa text för ett intro

                int Ship1p = 0;

                while (Ship1p >= 56 || Ship1p <= 10)   //Alla dom fem loopar som kommer nu gör samma sak, dom låter dig placera ett skepp
                {
                    Console.WriteLine("Place ship #1");

                    string Ship1 = Console.ReadLine();

                    bool isParsable = Int32.TryParse(Ship1, out Ship1p);   //Gör om det från en string till int vilket gör att man inte kan skriva bokstäver*

                    if (isParsable)

                        Console.WriteLine("");

                    else
                    {
                        Console.WriteLine("yeaaaa, not a number");   //Kollar att du skrev en siffra och säger till dig att göra om annars**
                    }


                    if (Ship1p >= 56 || Ship1p <= 10)
                    {
                        Console.WriteLine("Invalid number brother");    //Kollar att du skrev en siffra inom griden***
                    }
                }

                int Ship2p = 0;

                while (Ship2p >= 56 || Ship2p <= 10 || Ship2p == Ship1p)
                {
                    Console.WriteLine("Place ship #2");

                    string Ship2 = Console.ReadLine();

                    bool isParsable = Int32.TryParse(Ship2, out Ship2p);   //*

                    if (isParsable)

                        Console.WriteLine("");

                    else
                    {
                        Console.WriteLine("yeaaaa, not a number");   //**
                    }


                    if (Ship2p >= 56 || Ship2p <= 10 || Ship2p == Ship1p)
                    {
                        Console.WriteLine("Invalid number brother");   //*** plus att den kollatr så att du inte la ett skepp över ett annat
                    }
                }

                int Ship3p = 0;

                while (Ship3p >= 56 || Ship3p <= 10 || Ship3p == Ship1p || Ship3p == Ship2p)
                {
                    Console.WriteLine("Place ship #3");

                    string Ship3 = Console.ReadLine();

                    bool isParsable = Int32.TryParse(Ship3, out Ship3p);   //*

                    if (isParsable)

                        Console.WriteLine("");

                    else
                    {
                        Console.WriteLine("yeaaaa, not a number");   //**
                    }


                    if (Ship3p >= 56 || Ship3p <= 10 || Ship3p == Ship1p || Ship3p == Ship2p)
                    {
                        Console.WriteLine("Invalid number brother");   //***
                    }
                }

                int Ship4p = 0;

                while (Ship4p >= 56 || Ship4p <= 10 || Ship4p == Ship1p || Ship4p == Ship2p || Ship4p == Ship3p)
                {
                    Console.WriteLine("Place ship #4");

                    string Ship4 = Console.ReadLine();

                    bool isParsable = Int32.TryParse(Ship4, out Ship4p);   //*

                    if (isParsable)

                        Console.WriteLine("");

                    else
                    {
                        Console.WriteLine("yeaaaa, not a number");   //**
                    }


                    if (Ship4p >= 56 || Ship4p <= 10 || Ship4p == Ship1p || Ship4p == Ship2p || Ship4p == Ship3p)
                    {
                        Console.WriteLine("Invalid number brother");   //***
                    }
                }

                int Ship5p = 0;

                while (Ship5p >= 56 || Ship5p <= 10 || Ship5p == Ship1p || Ship5p == Ship2p || Ship5p == Ship3p || Ship5p == Ship4p)
                {
                    Console.WriteLine("Place ship #5");

                    string Ship5 = Console.ReadLine();

                    bool isParsable = Int32.TryParse(Ship5, out Ship5p);   //*

                    if (isParsable)

                        Console.WriteLine("");

                    else
                    {
                        Console.WriteLine("yeaaaa, not a number");   //**
                    }


                    if (Ship5p >= 56 || Ship5p <= 10 || Ship5p == Ship1p || Ship5p == Ship2p || Ship5p == Ship3p || Ship5p == Ship4p)
                    {
                        Console.WriteLine("Invalid number brother");   //***
                    }
                    Console.Clear();
                }

                Console.WriteLine("Great, all your ships are down");

                Console.WriteLine("Time for A.I to place");

                int AI1 = aiship.Next(10, 56);   //Alla rader som komer fram tills nästa kommentar är för att datorn ska lägga ut skepp

                Console.WriteLine("Ship #1 placed");

                int AI2 = aiship.Next(10, 56);

                Console.WriteLine("Ship #2 placed");

                int AI3 = aiship.Next(10, 56);

                Console.WriteLine("Ship #3 placed");

                int AI4 = aiship.Next(10, 56);

                Console.WriteLine("Ship #4 placed");

                int AI5 = aiship.Next(10, 56);

                Console.WriteLine("Ship #5 placed");

                Console.WriteLine("All ships have been placed, battle commences!");

                Console.WriteLine("Type coordinates yoy want to fire at in the same way you did when placing");   //Tells you the fight is on

                while (hpyou > 0 && hpai > 0)   //Loop som använder värden vi bestämmde i början för att räkna skepp
                {
                    string ship = Console.ReadLine();

                    if (ship == "showAll")
                    {
                        Console.WriteLine(AI1);   //Fusk för att jag ska kunna komma igenom snabbare
                    }

                    Console.WriteLine("Where will you fire");   //Frågar dig vart du vill skjuta

                    int hom = 0;

                    string shooting = Console.ReadLine();

                    bool IsParsable = Int32.TryParse(shooting, out hom);   //Kollar att du skrev en siffra

                    if (IsParsable)

                        Console.WriteLine("");

                    else
                    {
                        Console.WriteLine("not a numba brotha");   //Säger till dig om du inte gjorde det
                    }

                    if (hom == AI1 || hom == AI2 || hom == AI3 || hom == AI4 || hom == AI5)   //Kollar om det var en träff
                    {
                        Console.WriteLine("You hit!");

                        hpai--;

                        Console.WriteLine("They only have " + hpai + " ships left now");   //Säger till att du träffade
                    }

                    if (hom >= 56 || hom <= 10)
                    {
                        Console.WriteLine("Way off Captian, what were you thinking?");   //Säger till dig om du sköt utanför griden
                    }

                    if (hom != AI1 && hom != AI2 && hom != AI3 && hom != AI4 && hom != AI5)   //Kollar om du missade
                    {
                        Console.WriteLine("Thats a miss Captian");   //Säger till att du missade
                    }

                    int AIshot = aishot.Next(10, 56);

                    if (AIshot == Ship1p || AIshot == Ship2p || AIshot == Ship3p || AIshot == Ship4p || AIshot == Ship5p)   //Låter datorn skjuta
                    {
                        Console.WriteLine("We have been hit Captian");

                        hpyou--;

                        Console.WriteLine("We only have " + hpyou + " shpis left now");   //Säger till om du blev träffad
                    }

                    if (AIshot != Ship1p && AIshot != Ship2p && AIshot != Ship3p && AIshot != Ship4p && AIshot != Ship5p)   //Kollar om datorn missade
                    {
                        Console.WriteLine("They missed us Captian");   //Säger till om den gjorde det
                    }
                }

                if (hpyou == 0)
                {
                    Console.WriteLine("They drowned us all Captian");   //Ifall du förlorade
                }

                if (hpai == 0)
                {
                    Console.WriteLine("We got them all Captian");   //Ifall du vann
                }

                Console.WriteLine("Type EXIT to exit the game or just press enter to restart");

                restart = Console.ReadLine();   //Låter dig antingen stänga av eller starta om
            }
        }
    }
}
