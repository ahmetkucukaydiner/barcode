using BarcodeLib;
using System;

namespace barcode
{
    internal class Operation
    {
        static TYPE type = TYPE.PHARMACODE;

        public static Barcode CreateAndSave(string data)
        {
            Barcode barcodee = new Barcode();
            barcodee.Encode(type, data);

            barcodee.SaveImage(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + @"\barcode.png", BarcodeLib.SaveTypes.PNG);
            Console.WriteLine("Barkod oluşturuldu. Data saklandı. Saklanan data = {0}", data);
            return barcodee;
        }

        public static string ReadBarcode(Barcode barcodee)
        {
            return "Barkod = " + barcodee.RawData + " \n";
        }
    }
}
