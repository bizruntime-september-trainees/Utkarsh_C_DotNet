using System;
using System.Collections.Generic;
using System.IO;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;


namespace LoggerDemo
{
   class Logger  {

        private string CurrentDirectory {
            get; set;
        }

        private string FileName {
            get; set;
        }

        private string FilePath {
            get; set;
        }

        public Logger()
            {

            this.CurrentDirectory = @"C:\Users\hp\source\repos\LoggerDemo";
            this.FileName = "log.txt";
            this.FilePath = this.CurrentDirectory + "/" + this.FileName;
            }

        //..........Overriding Log method.............
        public  void Log(string Message)
        {
            using (System.IO.StreamWriter w = System.IO.File.AppendText(FilePath)) {

                w.Write("\r\n   :  ");
                w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(), DateTime.Now.ToLongDateString());
                w.WriteLine(" :{0} ", Message);
                w.WriteLine(".................................");
            }

        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            var logger = new Logger();
            logger.Log("Utkarsh ");
            logger.Log(" Pant");
            Console.ReadKey();
        }
    }
}
