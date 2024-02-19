using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tema18prkt2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Доступные форматы: XML,DOC,TXT");
            
            
            
            while (true)
            {
                Console.Write("Format - ");
                string a = Console.ReadLine();
                switch (a)
                {
                    case "XML":
                    case "xml":
                        AbstractHandler hand = new XMLHandler();
                        hand.Open();
                        hand.Create();
                        hand.Change();
                        hand.Save();
                        break;
                    case "DOC":
                    case "doc":
                        AbstractHandler hand2 = new DOCHandler();
                        hand2.Open();
                        hand2.Create();
                        hand2.Change();
                        hand2.Save();
                        break;
                    case "TXT":
                    case "txt":
                        AbstractHandler hand1 = new TXTHandler();
                        hand1.Open();
                        hand1.Create();
                        hand1.Change();
                        hand1.Save();
                        break;
                    case "END":
                    case "end":
                        return;
                    default:
                        Console.WriteLine("Введите доступные форматы");
                        break;

                }
            }
            Console.ReadKey();
            
        }
    }
}
