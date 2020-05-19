using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Enter line");
                int resInt = 0;
                string cell = Console.ReadLine();
                List<string> val = new List<string>();
                string res = string.Empty;
                for (int i = 0; i < cell.Length; i++)
                {
                    int a = string2int.getIndexofNumber(cell.Substring(i, 1));
                    if (a > -1)
                    {
                        val.Add(cell.Substring(i, 1));
                    }

                    res = string.Join("", val);
                }

                resInt = Convert.ToInt32(string.IsNullOrEmpty(res) ? "0" : res);


                Console.WriteLine("Return Value as Integer: {0}", resInt);
                Console.ReadLine();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public class string2int
        {

            public static int getIndexofNumber(string cell)
            {
                int a = -1, indexofNum = 10000;
                a = cell.IndexOf("0"); if (a > -1) { if (indexofNum > a) { indexofNum = a; } }
                a = cell.IndexOf("1"); if (a > -1) { if (indexofNum > a) { indexofNum = a; } }
                a = cell.IndexOf("2"); if (a > -1) { if (indexofNum > a) { indexofNum = a; } }
                a = cell.IndexOf("3"); if (a > -1) { if (indexofNum > a) { indexofNum = a; } }
                a = cell.IndexOf("4"); if (a > -1) { if (indexofNum > a) { indexofNum = a; } }
                a = cell.IndexOf("5"); if (a > -1) { if (indexofNum > a) { indexofNum = a; } }
                a = cell.IndexOf("6"); if (a > -1) { if (indexofNum > a) { indexofNum = a; } }
                a = cell.IndexOf("7"); if (a > -1) { if (indexofNum > a) { indexofNum = a; } }
                a = cell.IndexOf("8"); if (a > -1) { if (indexofNum > a) { indexofNum = a; } }
                a = cell.IndexOf("9"); if (a > -1) { if (indexofNum > a) { indexofNum = a; } }

                if (indexofNum != 10000)
                { return indexofNum; }
                else
                { return -1; }


            }
        
        }
    }
}
