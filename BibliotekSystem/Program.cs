using System;

namespace BibliotekSystem // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //Bog bog = new Bog();
            Bibliotek bib = new Bibliotek();


        }

        public class Forfatter

        {

            public string Navn { get; set; }

            public string Nationalitet { get; set; }

            public int Fødselsår { get; set; }  


            // Andre egenskaber for forfatteren



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

            public string Titel { get; set; }

            public string Forfatter { get; set; }

            public string Udgivelsesår { get; set; }

            public bool erTilgænglige { get; set; } = true;

            // Andre egenskaber for bogen



            // Konstruktør

            public Bog()

            {
                Bog bog1 = new Bog();
                {
                    Titel = "Harry Potter and the Philosopher's Stone";
                    Forfatter = "J.K Rowling";
                    Udgivelsesår = "1997";
                }
                Bog bog2 = new Bog();
                {
                    Titel = "To Kill a Mockingbird";
                    Forfatter = "Harper Lee";
                    Udgivelsesår = "1960";
                }
                Bog bog3 = new Bog();
                {
                    Titel = "The Great Gatsby";
                    Forfatter = "F. Scott Fitzgerald";
                    Udgivelsesår = "1925";
                }
                Bog bog4 = new Bog();
                {
                    Titel = "Pride and Prejudice";
                    Forfatter = "Jane Austen";
                    Udgivelsesår = "1813";
                }
                Bog bog5 = new Bog();
                {
                    Titel = "The Catcher in the Rye";
                    Forfatter = "J.D Salinger";
                    Udgivelsesår = "1951";
                }


            }

        }

        public class Bibliotek

        {

            private List<Bog> bøger = new List<Bog>(); // En liste til at gemme bøger

            private Dictionary<string, Forfatter> forfattere = new Dictionary<string, Forfatter>(); // Et dictionary til at gemme forfattere

            

            public void TilføjBog(Bog bog)

            {

                bøger.Add(bog);

                //bøger.ForEach(Console.WriteLine);
                foreach (var Bog in bøger)
                {
                    Console.WriteLine(Bog);
                }

                
            }



            public void TilføjForfatter(Forfatter forfatter)

            {

                forfattere[forfatter.Navn] = forfatter;

            }



            public void LåneBog(string bogTitel)

            {
                //Bog bog = new Bog();
                //// Implementer logik for at låne en bog her
                 
                //if (bogTitel == null)
                //{
                //    Console.WriteLine("Bogen ikke fundet!");
                //    return;
                //}
                
                //if (!bog.erTilgænglige)
                //{
                //    Console.WriteLine("Bogen er allerede lånt!");
                //    return;
                //}

                //bog.erTilgænglige = false;
                //Console.WriteLine("Tilykke! du har lånt bogen");

            }



            public void AflevereBog(string bogTitel)

            {
                //Bog bog = new Bog();
                //// Implementer logik for at aflevere en bog her

                //if (bogTitel == null)
                //{
                //    Console.WriteLine("Bogen ikke fundet!");
                //    return;
                //}

                //if (bog.erTilgænglige)
                //{
                //    Console.WriteLine("bogen er tilgænglige");
                //}

                //bog.erTilgænglige = true;
                //Console.WriteLine("Tak for at du aflevere bogen!");
            }



            public void FåBogInfo(string bogTitel)

            {

                // Implementer logik for at få information om en bog her

            }

        }
    }
}