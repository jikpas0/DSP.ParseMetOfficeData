using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetOfficeClient.Models;

namespace MetOfficeClient
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string isExit = string.Empty;
            while (!string.IsNullOrEmpty(isExit) && isExit.ToLower() != "exit")
            {
                PromptOperator promptOperator = new PromptOperator();
                isExit = Console.ReadLine();
            }
        }
    }
}
