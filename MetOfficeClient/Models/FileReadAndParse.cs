using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Server;

namespace Met.Client.Models
{
    public class FileReadAndParse
    {
        public List<string> HeaderColumnValues { get; set; }
        public List<string> DataColumnValues { get; set; }

        private StreamReader _reader = File.OpenText("../../MockDataSource/heathrowdata.txt");

        public string ReadTextFile()
        {
            bool startFound = false;
            string line;
            StringBuilder lineAggregate = new StringBuilder();
            List<string> headerItems = new List<string>();
            HeaderColumnValues = new List<string>();
            DataColumnValues = new List<string>();
            while ((line = _reader.ReadLine()) != null)
            {
                if (line.Contains("yyyy") || line.Contains("degC"))
                {
                    lineAggregate.Append(line);
                    headerItems.Add(line);

                    if (line.Contains("degC"))
                    {
                        StoreHeaderValues(headerItems);
                        startFound = true;
                    }
                }

                if (startFound)
                {
                    StoreRowValues(line);
                }
            }

            return lineAggregate.ToString();
        }

        public List<String> StoreHeaderValues(List<string> items)
        {
            List<string> itemTop = RemoveEmptyNodes(items[0].Split(' ').ToList());
            List<string> itemBottom = RemoveEmptyNodes(items[1].Split(' ').ToList());
            
            for (int i = 0; i < itemTop.Count(); i++)
            {
                if (i >= 2)
                {
                    HeaderColumnValues.Add(itemTop[i] + " " + itemBottom[i - 2]);
                }
                else
                {
                    HeaderColumnValues.Add(itemTop[i]);
                }
            }
            
            return new List<String>();
        }

        private List<string> RemoveEmptyNodes(List<string> items)
        {
            List<string> distinctItems = new List<string>();
            foreach (var item in items)
            {
                if (!string.IsNullOrEmpty(item))
                {
                    distinctItems.Add(item);
                }
            }
            return distinctItems;
        }

        public List<string> StoreRowValues(string items)
        {
            List<string> itemTop = RemoveEmptyNodes(items.Split(' ').ToList());
            

            for (int i = 0; i < itemTop.Count(); i++)
            {
                DataColumnValues.Add(itemTop[i]);
            }

            return new List<String>();
        }
    }
}
