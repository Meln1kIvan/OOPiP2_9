using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPiP2_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string fileName = "D:\\2 курс\\OOPiP2_9\\OOPiP2_9\\bin\\Debug\\paper.txt";

            double totalSum = File.ReadLines(fileName).Select(line => line.Split(' ').Select(int.Parse).Select(num => { double avg = (double)num; Console.WriteLine($"Содержимое строки: {avg}"); return avg; }).Sum()).Sum(); Console.WriteLine($"Сумма всех чисел: {totalSum}");
        }
    }
}
