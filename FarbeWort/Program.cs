/*
bool forthFahren=true;
while (forthFahren) {
Console.WriteLine("Hallo user! Gib dein Alter ein!");
string alter=Console.ReadLine(); ;
//int alt=Convert.ToInt32(Console.ReadLine());
    if (int.TryParse(alter, out int alt))
    {
        if (alt < 0 || alt > 125) Console.WriteLine("Alter darf nicht negativ oder bigger als 125 sein!");
        else
        {
            Console.WriteLine(alt+ " ist ok.\n");
            bool jaOderNein = true;
            
            while (jaOderNein) {
                Console.WriteLine("Forthfahren? (j/n)");
                string anwort = Console.ReadLine().ToLower();

                if (anwort.Equals("j")) jaOderNein = false;
                else if (anwort.Equals("n"))
                {
                    jaOderNein = false;
                    forthFahren = false;
                }
                else
                {
                    Console.WriteLine("Bitte j oder n");
                    continue;
                }

            }
                 
        }

    }
    else Console.WriteLine("Bitte Geben Sie Zahl ein");

}*/


using System;

bool forthfahren = true;

while (forthfahren)
{
    string rot = "Rot", blaue = "Blaue", grün = "Grün", etwas;
    Console.WriteLine($"\nWählen Sie eine Farbe(Buchstabe oder Wort):\n\n{rot}\n{blaue}\n{grün}\n");
    Console.WriteLine($"Für 'EXIT' geben Sie 1 ein !!\n");
    string wahl = Console.ReadLine().ToLower();
    
    if (wahl != "1")
    {

        if (wahl.Equals("r") || wahl.Equals("ro") || wahl.Equals("rot"))
        {

            Console.WriteLine("Schreiben Sie irgendwas:\n");
            Console.ForegroundColor = ConsoleColor.Red;
            etwas = Console.ReadLine();
            etwas = etwas.ToUpper();

            Console.WriteLine("\n" + etwas + "\n");
        }
        else if (wahl.Equals("b") || wahl.Equals("bl") || wahl.Equals("bla") || wahl.Equals("blau") || wahl.Equals("blaue"))
        {
            Console.WriteLine("Schreiben Sie irgendwas:\n");
            Console.ForegroundColor = ConsoleColor.Blue;
            etwas = Console.ReadLine();
            etwas = etwas.ToUpper();
            Console.WriteLine("\n" + etwas + "\n");
        }
        else if (wahl.Equals("g") || wahl.Equals("gr") || wahl.Equals("grü") || wahl.Equals("grün"))
        {
            Console.WriteLine("Schreiben Sie irgendwas:\n");
            Console.ForegroundColor = ConsoleColor.Green;
            etwas = Console.ReadLine();
            etwas = etwas.ToUpper();
            Console.WriteLine("\n" + etwas + "\n");
        }

        else
        {
            Console.WriteLine("Bitte geben Sie einen gültigen Buchstaben oder ein gültiges Wort ein!\n\n");
        }
        //Console.ResetColor();
    }
    else
    {
        Console.ResetColor();
        Console.WriteLine("Das Programm wird beendet.\n");
        forthfahren = false;
    }

   

}
bool fortfahren = true;
string mesaj, renk;
while (fortfahren)
{
    Console.BackgroundColor = ConsoleColor.White;
    Console.WriteLine("Nachricht");
    Console.WriteLine("Für EXIT 1");
    mesaj = Console.ReadLine().ToLower();
    if (!mesaj.Equals("1") )
    {
        Console.WriteLine("Farbe (r/b/g)");
        Console.WriteLine("Für EXIT 1");
        renk = Console.ReadLine().ToLower();

        if (!mesaj.Equals("1"))
        {
            MesajGoster(mesaj, renk);
        }
    }
      
    
   
    else fortfahren = false; 
}
   
 

void MesajGoster(string mesaj, string renk )
{
    

    switch (renk)
        {
            case "r":
            case "ro":
            case "rot":
                Console.ForegroundColor = ConsoleColor.Red;
                break;
            case "b":
            case "bl":
            case "bla":
            case "blau":
            case "blaue":
                Console.ForegroundColor = ConsoleColor.Blue;
                break;
            case "g":
            case "gr":
            case "grü":
            case "grün":
                Console.ForegroundColor = ConsoleColor.Green;
                break;
            case "1":
                Console.WriteLine("dont work");
                fortfahren = false;
                break;

            default:
                Console.WriteLine("Bitte geben Sie einen gültigen Buchstaben ein!");
                break;

        }

        Console.WriteLine(mesaj);
        //Console.ResetColor();
    }
    
      




