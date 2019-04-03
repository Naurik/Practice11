using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace Practice13
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] xmlArray = {"Name","Surname","Age","Education", "Status" };
            XDocument xml = XDocument.Load("NewXmlFile.xml");
            int i = 0;
            var hello = from body in xml.Descendants("body")
                        select new
                        {
                            text = body.Element(xmlArray[i]).Value,
                        };
            while (i < xmlArray.Length)
            {
                foreach (var body in hello)
                {
                    Console.Write(body.text + " ");
                }
                i++;
            }
            xml.Save("NewXmlFile.xml");
            Console.ReadLine();
        }
    }
    }
