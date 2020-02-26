using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Entidades
{
    public class Log
    {
        private string Path = "";

        public Log(string Path)
        {
            this.Path = Path;
        }

        public void Add(string log)
        {
            CreateDirectory();
            string nombre = GetNameFile();
            string cadena = "";

           
            cadena += DateTime.Now + System.Environment.MachineName +" - " + log +" " + Environment.NewLine;
            
            StreamWriter sw = new StreamWriter(Path + "/" + nombre, true);
            sw.Write(cadena);
            sw.Close();

        }

        #region Helper
        private string GetNameFile()
        {
            string nombre = "log_" + DateTime.Now.Year + "_" + DateTime.Now.Month + "_" + DateTime.Now.Day + ".txt";

            return nombre;
        }


        private void CreateDirectory()
        {
            try
            {
                if (Directory.Exists(Path))
                    Directory.CreateDirectory(Path);
            }
            catch (DirectoryNotFoundException ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion
    }
}
