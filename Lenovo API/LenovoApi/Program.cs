using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LenovoApiLibrary;


namespace LenovoApi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**********************************************************************************************");
            Console.WriteLine("Lenovo Warranty Lookup - Einzelabfrage [ https://pcsupport.lenovo.com/ch/en/warrantylookup#/ ]");
            Console.WriteLine("**********************************************************************************************\n");

            Console.Write("Seriennummer eingeben: ");
            string serial = Console.ReadLine();
            serial = "PG01GTB2";

           
                MachineInfo mi = Api.GetMachineInfo(serial);
                Console.WriteLine("--- Gerät ---");
                Console.WriteLine();
                Console.WriteLine($"Produktgruppe: {mi.ProductGroup}");
                Console.WriteLine($"Produkt: {mi.ProductName}");
                Console.WriteLine($"Modell: {mi.Model}");
            Console.WriteLine();


            Console.WriteLine("--- Aktuelle Garantie ---");
            Console.WriteLine($"Name: {mi.CurrentWarranty.Name}");
            Console.WriteLine($"Kategorie: {mi.CurrentWarranty.Category}");
            Console.WriteLine($"Typ: {mi.CurrentWarranty.Typ}");
            Console.WriteLine($"Dauer: {mi.CurrentWarranty.Duration} Monate");
            Console.WriteLine($"Von: {Convert.ToDateTime(mi.CurrentWarranty.Start)}");
            Console.WriteLine($"Bis: {Convert.ToDateTime(mi.CurrentWarranty.End)}");
            Console.WriteLine($"Beschreibung: {mi.CurrentWarranty.Description}");
            Console.WriteLine();


            Console.WriteLine("--- Garantie Upgrade Optionen  ---");
            Console.WriteLine();
            int counter = 0;
            foreach (var option in mi.UpgradeWarrantyList.WarrantyList)
            {
                Console.WriteLine();

                counter++;
                Console.WriteLine($"Option {counter}");
                Console.WriteLine("--------");
                Console.WriteLine($"Name: {option.Name}"); 
                Console.WriteLine($"Kategorie: {option.Category}"); 
                Console.WriteLine($"Typ: {option.Typ}"); 
                Console.WriteLine($"Dauer: {option.Duration} Monate"); 
                Console.WriteLine($"Von: {Convert.ToDateTime(option.Start)}"); 
                Console.WriteLine($"Bis: {Convert.ToDateTime(option.End)}");
                Console.WriteLine($"Beschreibung: {option.Description}"); 
            }




            // TODO 
            //  - add a reference to the LenovoApiLibrary project 
            //  - include the LenovoApiLibrary-namespace in this projects using section 
            //  - call the static GetMachineInfo()-method of the library's Api class to obtain info 
            //     (use serial number 'PG01GTB2' if you don't have another serial) 
            //  - write obtained information to console 

            Console.ReadKey();
        }
    }
}
