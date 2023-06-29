namespace BibliotekSystem // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Bibliotek bib = new Bibliotek();

            bib.AddBooks();


            // MENU
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Bibliotek");
                Console.ResetColor();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("(1)Bøger \n(2)Forfatter \n(3)Låne Bog \n(4)Aflevere Bog \n(5)Bog Info ");
                Console.ResetColor();

                Console.Write("valg: ");
                int x = Convert.ToInt32(Console.ReadLine());


                switch (x)
                {
                    case 1:
                        bib.TilføjBog();
                        break;
                    case 2:
                        bib.TilføjForfatter();
                        break;
                    case 3:
                        bib.LåneBog();
                        break;
                    case 4:
                        bib.AflevereBog();
                        break;
                    case 5:
                        bib.FåBogInfo();
                        break;
                    default:
                        Console.WriteLine("Forkert input! Prøve igen!");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }
            

        }

        public class Forfatter

        {
            // properties
            public string Navn { get; set; }

            public string Nationalitet { get; set; }

            public int Fødselsår { get; set; }




            // Konstruktør

            public Forfatter(string navn, string nationalitet, int fødselsår)

            {
                Navn = navn;
                Nationalitet = nationalitet;
                Fødselsår = fødselsår;
            }

        }

        public class Bog

        {
            //Bogen egenskaber/properties
            public string Titel { get; set; }

            public string Forfatter { get; set; }

            public int Udgivelsesår { get; set; }

            public int Sider { get; set; }

            public bool erLånt { get; set; }


            // Konstruktør/constructor

            public Bog(string titel, string forfatter, int udgivelsesår, int sider, bool erL)
            {
                Titel = titel;
                Forfatter = forfatter;
                Udgivelsesår = udgivelsesår;
                Sider = sider;
                erLånt = erL;

            }


        }

        public class Bibliotek

        {
            
            // Bøger Liste
            private List<Bog> bøger = new List<Bog>(); // En liste til at gemme bøger

            //Forfatter Dictionary 
            private Dictionary<string, Forfatter> forfattere = new Dictionary<string, Forfatter>(); // Et dictionary til at gemme forfattere

            public void TilføjBog(Bog bog)
            {
                bøger.Add(bog);
            }

            public void AddBooks()
            {
                //Tilføjer eksta bøger til listen
                bøger.Add(new Bog("Harry Potter and the Philosopher's Stone", "J.K Rowling", 1997, 223, true));
                bøger.Add(new Bog("To Kill a Mockingbird", "Harper Lee", 1960, 285, false));
                bøger.Add(new Bog("The Great Gatsby", "F. Scott Fitzgerald", 1925, 208, true));
                bøger.Add(new Bog("Pride and Prejudice", "Jane Austen", 1813, 273, false));
                bøger.Add(new Bog("The Catcher in the Rye", "J.D Salinger", 1951, 234, false));

            }

            public void TilføjBog()
            {
                

            //Bog Menu  
            repeat:
                Console.WriteLine("\nTilføj Bog(1) |\tVis Bøger(2)");
                Console.Write("valg: ");
                string valg = Console.ReadLine();
                Console.Clear();

                if (valg == "1")
                {
                    Console.Clear();

                    Console.WriteLine("Tilføj bog");

                    Console.Write("Titel: ");
                    string Titel = Console.ReadLine();

                    Console.Write("Forfatter: ");
                    string Forfatter = Console.ReadLine();

                    Console.Write("Udgivelsesår: ");
                    int Udgivelsesår = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Antal Sider: ");
                    int Sider = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Bogen er Tilføjet!");

                    bøger.Add(new Bog(Titel, Forfatter, Udgivelsesår, Sider, false));

                    Console.ReadKey();
                    Console.Clear();

                    goto repeat;
                }
                if (valg == "2")
                {

                    foreach (var Bog in bøger)
                    {
                        if(Bog.erLånt == false)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine(Bog.Titel);
                            Console.ResetColor();
                            
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine(Bog.Titel);
                            Console.ResetColor();
                        }
                       
                    }
                    
                }
                else if (valg != "1" && valg != "2")
                {
                    Console.WriteLine("Forkert input! Tryk enter for at Prøve igen");
                    Console.ReadKey();
                    Console.Clear();
                    goto repeat;
                }

            }

            
            public void TilføjForfatter()
            {
                //inserted data forfattere
                Forfatter[] forfatter =
                        {     
                    //data
                    new Forfatter("J.K Rowling", "Britisk", 1965),
                    new Forfatter("Harper Lee", "Amerikansk", 1926),
                    new Forfatter("F. Scott Fitzgerald", "Amerikansk", 1896),
                    new Forfatter("Jane Austen", "Britisk", 1775),
                    new Forfatter("J.D Salinger", "Amerikansk", 1919)
                };

                //tilføjer til dictionary
                

                //Input

                Console.Clear();

                repeat:
                Console.WriteLine("\n(1)Tilføj Forfatter | (2)Find Forfatter");
                Console.Write("valg: ");
                int valg = int.Parse(Console.ReadLine());

                if (valg == 1)
                {
                    Console.Write("Navn: ");
                     string Navn = Console.ReadLine();

                    Console.Write("Nationalitet: ");
                    string Nationalitet = Console.ReadLine();

                    Console.Write("Fødselsår: ");
                    int Fødsel = Convert.ToInt32(Console.ReadLine());

                    // tilføjer user inputs til dictionary
                    forfattere.Add(Navn, new Forfatter(Navn, Nationalitet, Fødsel));

                    //!!! SOLVE PROBLEM: Show the new added inputs in display array
                    foreach (Forfatter items in forfatter)
                    {
                        forfattere.Add(items.Navn, items);
                    }

                    // message
                    Console.WriteLine("Forfatteren er Tilføjet!");
                    Console.ReadKey();
                    Console.Clear();
                    goto repeat;

                }

                // Find info om forfatteren
                if (valg == 2)
                {
                 
                    foreach (Forfatter items in forfatter)
                    {
                        Console.ForegroundColor = ConsoleColor.DarkYellow;
                        Console.WriteLine($"{items.Navn}");
                        Console.ResetColor();
                    }
                    Console.WriteLine("");
                    repeat2:
                    Console.Write("Find Info om forfatter: ");
                    string fnavn = Console.ReadLine();

                    foreach (Forfatter items in forfatter)
                    {
                        // if dictionary key contains (_name_)
                        if (forfattere.ContainsKey(fnavn))
                        {
                            Forfatter ft = forfattere[fnavn];
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\nFUNDET!!");
                            Console.ForegroundColor = ConsoleColor.DarkYellow;
                            Console.WriteLine($"\nNavn: {ft.Navn} \nNationalitet: {ft.Nationalitet} \nFølsesår: {ft.Fødselsår} \n");
                            Console.ResetColor();
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Forfatteren findes ikke! Prøve igen.\n");
                            Console.ReadKey();
                            goto repeat2;
                        }

                    }
                }
               
            }


            // Låne bog
            public void LåneBog()
            {
            igen:
                Console.Clear();
                Console.Write("Lån en bog: ");
                string bogen = Console.ReadLine();

                foreach (var Bog in bøger)
                {
                    
                    if (Bog.Titel.Contains(bogen))
                    {
                        string x = Bog.Titel;

                        if (Bog.erLånt != true)
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"\n'{x}' er KLAR til lån!");
                            Console.ResetColor();

                            Console.WriteLine("\nja | nej");
                            Console.Write("\nVil du låne bogen? ");
                            string y = Console.ReadLine();

                            switch (y)
                            {
                                case "ja":
                                    Console.WriteLine("Tillykke du har lånt bogen!");
                                    Bog.erLånt = true;
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                case "nej":
                                    Console.WriteLine("Tast for at afslutte");
                                    Console.Clear();
                                    break;
                                    Console.Clear();
                                    break;
                                default:
                                    break;
                            }

                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine($"\n'{x}' er LÅNT!");
                            Console.ResetColor();
                            Console.ReadKey();
                        }
                    }
                      
                }
                // ELSE FEJL!!! SOLVE PROBLEM

                //Console.ForegroundColor = ConsoleColor.DarkRed;
                //Console.WriteLine($"'{bogen}' FINDES IKKE! Prøve igen!");
                //Console.ResetColor();
                //Console.ReadKey();
                //goto igen;

            }

            public void AflevereBog()
            {
                Console.Clear ();
                Console.Write("Aflevere Bog: ");
                string bogtitel = Console.ReadLine();
                
                Bog bog = FindBog(bogtitel);

                if (bog != null && bog.erLånt == true)
                {
                    bog.erLånt = false;
                   
                    Console.WriteLine($"\n{bog.Titel} Aflevet.\n");
                }
                else
                {
                    Console.WriteLine($"\n{bog.Titel} er IKKE fundet eller Bogen er allerede tilgænglig.\n");
                }
                

            }

            private Bog FindBog(string title)
            {
                foreach(Bog bog in bøger)
                {
                    if (bog.Titel == title)
                    { return bog;}
                }
                return null;
            }


            public void FåBogInfo()
            {
                Console.Clear();
                Console.WriteLine("Info om bogen");
                Console.WriteLine("Tast ind bogens titel eller (2) for at vise alle bøger");
                Console.Write("Tast: ");
                string bogTitel = Console.ReadLine();

                foreach (var bog in bøger)
                {
                    if (bog.Titel == bogTitel)
                    {
                        string hm = "";
                        if(bog.erLånt == false)
                        {
                            hm = "Ja";
                        }
                        else
                        { hm = "Nej"; }

                        Console.WriteLine($"\nOm '{bog.Titel}'\n Forfatter: {bog.Forfatter}\n Sider: {bog.Sider}\n Udgivelsesår: {bog.Udgivelsesår}\n Tilgængelig? {hm}\n");

                        
                    }
                    else if (bogTitel == "2") 
                    {
                        Console.WriteLine(bog.Titel);
                    }
                }
            }

        }

        

        



    }
}