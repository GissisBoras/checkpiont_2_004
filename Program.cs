using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Xml.Linq;
using checkpiont_2_004;
using System.IO;// För att kunna spara till en fíl

namespace checkpiont_2_004
{
    internal class Program
    {
        static List<Inventory> inventoryProducts = new List<Inventory>(); // Lista som lagrar produkter i Inventory
        public static double totalSumma = 0;
        static void Main() //(string[] args)
        {
            //välj om ett inventory ska läggas till eller programmet avslutas
            //Lägg till information i inventory
            

            SkrivUtMeny();

            while (true)
            {
                // Gör ett val 
                // välj om användaren skall avsluta eller lägga in ett nytt lagerobjekt
                // (q) avslutar
                // (n) lägger till
                // (v) visa listan
                // (p) visa totalt pris //sepparat först 
                // (s) spara listan på fil. Får det inte att funka just nu så har kommenterat bort den delen
                // sedan startar användaren om från början

                

                Console.WriteLine("make a selection: ");
                Console.Write("Lägg till produkt (n), visa listan (v), Visa Totalt pris (p) eller avsluta (q): ");

                string selection = Console.ReadLine();
                selection = selection.ToLower().Trim();


                if (selection == "q") //quit
                {
                    break;
                }
                else if (selection == "n") //ny
                {
                    LaggTillProdukt();
                }
                else if (selection == "v") //visa
                {
                    SkrivUtLista();
                }
                //else if (selection == "s") //spara lista i fil
                //{
                //    SparaTillFil();
                //}

                else if (selection == "p")
                {
                    BeraknaTotaltPris();

                }
                else
                    Console.Write("Gör ett nytt val");

            }

        }


        // Functions
        // =========
        static void SkrivUtMeny()
        {
            // Skriver ut menyn
            Console.WriteLine("Add Inventorydata: ");
            Console.WriteLine("===================");
            Console.WriteLine();
            Console.WriteLine("Lägg till ny (n)");
            Console.WriteLine("Visa listan (v)");
            Console.WriteLine("Avsluta quit (q)");
            Console.WriteLine();
        }

        static void LaggTillProdukt()
        {
            //Lägg till produkter och spara dem i listan InventoryProducts

            Console.Write("Lägg till en Category: ");
            string Category = Console.ReadLine();

            Console.Write("Lägg till ett produktnamn: ");
            string Name = Console.ReadLine();

            Console.Write("Lägg till priset: ");
            
            double Price = Convert.ToDouble(Console.ReadLine());

            Inventory newInventory = new Inventory(Category, Name, Price);

            inventoryProducts.Add(newInventory);

            Console.WriteLine("Product tillagd.");

        }

        static void SkrivUtLista()
        {
            //Skriver ut listan Inentory
            
            Console.WriteLine("Sparad lista");
            Console.WriteLine("============");
            Console.WriteLine();
           
           
            foreach (var Inventory in inventoryProducts.OrderBy(inventoryProducts => inventoryProducts.Category)) 
            {
                Console.WriteLine($"{Inventory.Category} : {Inventory.Name} : {Inventory.Price}");
            }
        }

        static void BeraknaTotaltPris()
        // Calculate the total price for all inventoryp products
        {
            double summaKr = 0;
            
            foreach (var Inventory in inventoryProducts.OrderBy(inventoryProducts => inventoryProducts.Category))
            {
                summaKr = Inventory.Price;
                totalSumma += summaKr;
            }
            Console.WriteLine("totalsumma " + totalSumma);
            Console.Read(); 
        }
    

        //static void SparaTillFil(string InventoryList)
        ////lägg till InventoryListObjekt till en fil
        //{

        //    InventoryList IL = new InventoryList(InventoryFil);

        //    foreach (var inventory in Inventory)
        //    {
        //        string inventoryText = inventory.Category + inventory.Name + inventory.Price);
        //        IL.WriteLine(inventoryText);
        //    }
        //}
    }
}