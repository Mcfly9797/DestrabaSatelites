using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Modelo;
namespace Controladores
{
    public class DestrabarPrensa
    {
        public List<PrensaLog> DestraSatTraerLogs ( int nroSat )
        {
            List<PrensaLog> ListPrensasAct = new List<PrensaLog>();
            List<PrensaLog> ListPrensasAnt = new List<PrensaLog>();
            int CantPren = 1; 
            while (CantPren > 0) //Si la cantidad de prensas fallidas es mayor que 0 vuelvo a ejecutar el sp
            {
                Console.WriteLine("El numero de prensas fallando es mayor que 10 ");
                switch (nroSat)
                {
                    case 1:
                        ListPrensasAct = new BdDestrSat().SP_DestrabaSat1(); //Destrabo sat y traigo la respuesta de las prensas fallidas de la bd
                        Console.WriteLine("Destrabando Sat 1");
                        break;
                    case 2:
                        ListPrensasAct = new BdDestrSat().SP_DestrabaSat2(); //Destrabo sat y traigo la respuesta de las prensas fallidas de la bd
                        Console.WriteLine("Destrabando Sat 2");
                        break;
                    case 3:
                        ListPrensasAct = new BdDestrSat().SP_DestrabaSat3(); //Destrabo sat y traigo la respuesta de las prensas fallidas de la bd
                        Console.WriteLine("Destrabando Sat 3");
                        break;
                    case 4:
                        ListPrensasAct = new BdDestrSat().SP_DestrabaSat4(); //Destrabo sat y traigo la respuesta de las prensas fallidas de la bd
                        Console.WriteLine("Destrabando Sat 4");
                        break;
                }
                ListPrensasAnt = ListPrensasAct;                            // Guardo el valor de la lista anterior antes de volver a actualizar su valor
                CantPren = ListPrensasAct.Count;
            }
            Console.WriteLine("Destrabado" + nroSat);
            return ListPrensasAnt;
        }

        public void EscribirLog(List<PrensaLog> logs, int nroSat )
        {
            Log oLog = new Log(@".\");
            oLog.Add("Lista de prensas del satelite" + nroSat + ": " + Environment.NewLine);
            foreach (var prensa in logs)
            {
                oLog.Add(prensa.Record_id.ToString() + Environment.NewLine);
                oLog.Add(prensa.Press.ToString() + Environment.NewLine);
                oLog.Add(prensa.Item0.ToString() + Environment.NewLine);
                oLog.Add(prensa.Item1.ToString() + Environment.NewLine);
                oLog.Add(prensa.Item2.ToString() + Environment.NewLine);
                oLog.Add(prensa.Item3.ToString() + Environment.NewLine);
                oLog.Add(prensa.Item4.ToString() + Environment.NewLine);
                oLog.Add(prensa.Item5.ToString() + Environment.NewLine);
                oLog.Add(prensa.Item6.ToString() + Environment.NewLine);
                oLog.Add(prensa.Item7.ToString() + Environment.NewLine);
                oLog.Add(prensa.Item8.ToString() + Environment.NewLine);
                oLog.Add(prensa.Item9.ToString() + Environment.NewLine);
                oLog.Add(prensa.Item10.ToString() + Environment.NewLine);
                oLog.Add(prensa.Item11.ToString() + Environment.NewLine);
                oLog.Add(prensa.Item12.ToString() + Environment.NewLine);
                oLog.Add(prensa.Item13.ToString() + Environment.NewLine);
                oLog.Add(prensa.Item14.ToString() + Environment.NewLine);
                oLog.Add(prensa.Item15.ToString() + Environment.NewLine);
                oLog.Add(prensa.Packet.ToString() + Environment.NewLine);
                oLog.Add(prensa.Status.ToString() + Environment.NewLine);
                oLog.Add(prensa.Attempts.ToString() + Environment.NewLine);
                oLog.Add(prensa.Insert_date.ToString() + Environment.NewLine);
            }
        }




        public string ConvertirAtexto(List<PrensaLog> logs)
        {
           

            StringBuilder oLog = new StringBuilder();

            foreach (var prensa in logs)
            {
                oLog.Append(prensa.Record_id.ToString());
                oLog.Append(prensa.Press.ToString());
                oLog.Append(prensa.Item0.ToString() + Environment.NewLine);
                oLog.Append(prensa.Item1.ToString() + Environment.NewLine);
                oLog.Append(prensa.Item2.ToString() + Environment.NewLine);
                oLog.Append(prensa.Item3.ToString() + Environment.NewLine);
                oLog.Append(prensa.Item4.ToString() + Environment.NewLine);
                oLog.Append(prensa.Item5.ToString() + Environment.NewLine);
                oLog.Append(prensa.Item6.ToString() + Environment.NewLine);
                oLog.Append(prensa.Item7.ToString() + Environment.NewLine);
                oLog.Append(prensa.Item8.ToString() + Environment.NewLine);
                oLog.Append(prensa.Item9.ToString() + Environment.NewLine);
                oLog.Append(prensa.Item10.ToString() + Environment.NewLine);
                oLog.Append(prensa.Item11.ToString() + Environment.NewLine);
                oLog.Append(prensa.Item12.ToString() + Environment.NewLine);
                oLog.Append(prensa.Item13.ToString() + Environment.NewLine);
                oLog.Append(prensa.Item14.ToString() + Environment.NewLine);
                oLog.Append(prensa.Item15.ToString() + Environment.NewLine);
                oLog.Append(prensa.Packet.ToString() + Environment.NewLine);
                oLog.Append(prensa.Status.ToString() + Environment.NewLine);
                oLog.Append(prensa.Attempts.ToString() + Environment.NewLine);
                oLog.Append(prensa.Insert_date.ToString() + Environment.NewLine);
            }

             return oLog.ToString();
        }
    }
}



