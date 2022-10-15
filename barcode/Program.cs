using BarcodeLib;
using System;

namespace barcode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Barcode barcode = Operation.CreateAndSave("777");
             Console.WriteLine(Operation.ReadBarcode(barcode)); */


            Barcode barcode = Operation.CreateAndSave("17698");
            Console.WriteLine(Operation.ReadBarcode(barcode));

        }
    }
}
