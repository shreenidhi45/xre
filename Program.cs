using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                // Write XML file
                StreamWriter xmlWriter = new StreamWriter("C:\\Users\\shreenidhi\\Documents\\FileHandle//sampe.xml");
                xmlWriter.WriteLine("<root>");
                xmlWriter.WriteLine("   <element>Hello Shree</element>");
                xmlWriter.WriteLine("</root>");
                xmlWriter.Close();

                // Write HTML file
                StreamWriter htmlWriter = new StreamWriter("C:\\Users\\shreenidhi\\Documents\\FileHandle\\simple.html");
                htmlWriter.WriteLine("<html>");
                htmlWriter.WriteLine("   <body>");
                htmlWriter.WriteLine("      <h1>Chandrayan-3 landed successfully</h1>");
                htmlWriter.WriteLine("   </body>");
                htmlWriter.WriteLine("</html>");
                htmlWriter.Close();

                // Write text file
                StreamWriter textWriter = new StreamWriter("C:\\Users\\shreenidhi\\Documents\\FileHandle\\text.txt");
                textWriter.WriteLine("This is a normal file.");
                textWriter.Close();
            }
        }
    }

    
