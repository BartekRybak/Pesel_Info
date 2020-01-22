using System;

namespace PeselChecker
{
    class Program
    {
        static PeselInfo P_Info;
        static void Main(string[] args)
        {
            Console.Write("PESEL: ");
            string pesel = Console.ReadLine();

            P_Info = new PeselInfo(pesel);
            Console.WriteLine("=====================");
            Console.WriteLine("Year: " + P_Info.GetYear());
            Console.WriteLine("Month: " + P_Info.GetMonth());
            Console.WriteLine("Day: " + P_Info.GetDay());
            Console.WriteLine("Sex:" + P_Info.GetSex());
            Console.WriteLine("CheckSum: " + P_Info.GetCheckSum());
            Console.Read();
        }
    }
}
