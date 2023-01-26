using System.Net.Mime;

namespace Backup_program
{
    internal abstract class Storage
    {
        public string MediaNames { get; set; }

        public string MediaModel { get; set; }

        public double TotalMemory { get; set; }

        public double FreeMemory(double filledSize) { return TotalMemory - filledSize; }

        public void Coppy() { }

        public void PrintDeviceİnfo()
        {
            Console.WriteLine($"Name: {MediaNames}\nModel:{MediaModel}\nTotalMemory:{TotalMemory}\nFree Memory:{FreeMemory}");
        }

    }
}
