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

        static void Main() //(string[] args)
        {
            //välj om ett inventory ska läggas till eller programmet avslutas
            //Lägg till information i inventory

            SkrivUtMeny();

            while (true)
            {
                Console.WriteLine("make a selection: ");
                Console.Write("Lägg till produkt (n), visa listan (v), spara listan (s) eller avsluta (q): ");
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
                else
                    Console.Write("Gör ett nytt val");

            }

        }


        // Functions
        // =========
        static void SkrivUtMeny()
        {
            Console.WriteLine("Add Inventorydata: ");
            Console.WriteLine("===================");
            Console.WriteLine();
            Console.WriteLine("Lägg till ny (n)");
            Console.WriteLine("Visa listan (v)");
            Console.WriteLine("Avsluta med quit (q)");
            Console.WriteLine();
        }

        static void LaggTillProdukt()
        {
            //Lägg till produkter och spara dem i listan Inventory

            Console.Write("Lägg till en Category: ");
            string Category = Console.ReadLine();

            Console.Write("Lägg till ett produktnamn: ");
            string Name = Console.ReadLine();

            Console.WriteLine("Lägg till priset: ");
            // float Price = Convert.ToSingle(Console.ReadLine()); // konverterar inmatat värde till Single (float) för att kunna lagra värdet i price variabeln
            double Price = Convert.ToDouble(Console.ReadLine());

            Inventory newInventory = new Inventory(Category, Name, Price);

            //Inventory.Add(newInventory);
            inventoryProducts.Add(newInventory);

            Console.WriteLine("Product tillagd.");

        }

        static void SkrivUtLista()
        {
            Console.WriteLine("Sparad lista");
            Console.WriteLine("============");
            Console.WriteLine();
            //static List<Inventory> inventoryProducts = new List<Inventory>();

            foreach (var Inventory in inventoryProducts.OrderBy(inventoryProducts => Inventory.Category)) 
                                    //inventoryProducts.OrderBy(inventoryProducts => Inventory.Category))
            {
                Console.WriteLine($"inventory.Category");
                //static List<Inventory> inventoryProducts = new List<Inventory>(); //
            }
        }

        ////lägg till objekt till en fil
        //static void SparaTillFil(string InventoryList)
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