﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Controladores;
using Entidades;

namespace Test_Consola
{
    class Program
    {



        static void Main(string[] args)
        {


            
            Log oLog = new Log(@".\");
            oLog.Add("Prueba");

            bool flagError = false;

            new DestrabarPrensa().DestraSatTraerLogs(1, ref flagError );

            Console.Write("Press <Enter> to exit... ");
            while (Console.ReadKey().Key != ConsoleKey.Enter) { }
        }
    }
}
