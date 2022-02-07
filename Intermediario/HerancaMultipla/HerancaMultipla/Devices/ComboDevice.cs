using System;

namespace HerancaMultipla.Devices
{
    class ComboDevice : Device, IPrinter, IScanner
    {
        public void Print(string document)
        {
            Console.WriteLine($"Combo device print: {document}");
        }

        public override void ProcessDoc(string document)
        {
            Console.WriteLine($"Combo Device processing: {document}");
        }

        public string Scan()
        {
            return "Combo device scan result";
        }
    }
}
