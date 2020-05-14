using System;

namespace LatihanPolymorphism
{
    class PrinterWindows : IPrinterWindows
    {
        public void Show()
        {
            Console.WriteLine("Printer Windows display dimension: ");
        }

        public void Print()
        {
            Console.WriteLine("Printer Windows printing...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            PrinterWindows printer;

            Console.WriteLine("Pilih Printer : ");
            Console.WriteLine("1. Epson");
            Console.WriteLine("2. Canon");
            Console.WriteLine("3. LaserJet\n");

            Console.WriteLine("Nomer Printer [1..3] : ");
            int nomorPrinter = Convert.ToInt32(Console.ReadLine());

            if (nomorPrinter == 1)
                printer = new Epson();
            else if (nomorPrinter == 2)
                printer = new Canon();
            else
                printer = new LaserJet();

            printer.Show();
            printer.Print();

            Console.ReadKey();

        }
    }

    interface IPrinterWindows
    {
        void Show();
        void Print();
    }

    class Canon : IPrinterWindows
    {
        public void Show()
        {
            Console.WriteLine("Printer Canon dimension: 9.5 * 12");
        }

        public void Print()
        {
            Console.WriteLine("Canon printer printing ....");
        }
    }

    class Epson : IPrinterWindows
    {
        public void Show()
        {
            Console.WriteLine("Printer Epson dimension: 10 * 11");
        }

        public void Print()
        {
            Console.WriteLine("Epson printer printing ....");
        }
    }

    class LaserJet : IPrinterWindows
    {
        public void Show()
        {
            Console.WriteLine("Printer LaserJet dimension: 12 * 12");
        }

        public void Print()
        {
            Console.WriteLine("LaserJet printer printing ....");
        }
    }
}