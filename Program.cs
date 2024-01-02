namespace Bilforhandleren
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bil Porsche = new Bil ("Posrsche", 2018, 674893, 32234, 1000000);
            Bil Skoda = new Bil ("Skoda", 2005, 9825432, 20143, 499000);
            Bil Tesla = new Bil ("Tesla", 2022, 857429, 15673, 499000);
            Porsche.PrintBil();
            Skoda.PrintBil();
            Tesla.PrintBil();

            List<Bil> bils = new List<Bil> ();
            bils.Add (Porsche);
            bils.Add (Skoda);
            bils.Add(Tesla);
            PrintCars(bils);

            Console.WriteLine("Velg mellom tre ulike kjøpskategorier. Tast 1 for ny bil, tast 2 for VW-bil og tast 3 for billigere bil.");

            var input = Console.ReadLine ();    
            switch (input)
            {
                case "1":
                    newCar(bils);
                    break;
                    case "2":
                    VWGroup(bils);
                    break;
                    case "3":
                    ØkonomiBil(bils);
                    break;
                       
            }

            

        }
        static void PrintCars(List<Bil> bils)
        {
            foreach (var b in bils)
            {
                b.PrintBil();
            }                  

        }
        static void newCar(List<Bil> bils)
        {
            foreach (var b in bils)
            {
                if (b.Årsmodell > (int)2015)
                {
                    b.PrintBil();
                }
            }
        }
        static void VWGroup(List<Bil> bils)
        {
            foreach (var b in bils)
            {
                if (b.Merke == "Porsche" || b.Merke == "Skoda")
                {
                    b.PrintBil();
                }
            }
        }
        static void ØkonomiBil(List<Bil> bils)
        {
            foreach (var b in bils)
            {
                if (b.Pris < (int)500000)
                {
                    b.PrintBil();
                }
            }
        }

      


    }
    

}