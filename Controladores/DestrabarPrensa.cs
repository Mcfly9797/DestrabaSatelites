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
        public List<PrensaLog> DestraSatTraerLogs ( int nroSat, ref bool flagError )
        {
            List<PrensaLog> ListPrensasAct = new List<PrensaLog>();
            List<PrensaLog> ListPrensasAnt = new List<PrensaLog>();
            int CantPren = 1; 
            while (CantPren > 0) //Si la cantidad de prensas fallidas es mayor que 0 vuelvo a ejecutar el sp
            {
                Console.WriteLine("Destrabando Sat: " + nroSat.ToString());
                switch (nroSat)
                {
                    case 1:
                        ListPrensasAct = new BdDestrSat().SP_DestrabaSat1(new List<PrensaLog>(), ref flagError); //Destrabo sat y traigo la respuesta de las prensas fallidas de la bd
                        break;
                    case 2:
                        ListPrensasAct = new BdDestrSat().SP_DestrabaSat2(new List<PrensaLog>(), ref flagError); //Destrabo sat y traigo la respuesta de las prensas fallidas de la bd                 
                        break;
                    case 3:
                        ListPrensasAct = new BdDestrSat().SP_DestrabaSat3(new List<PrensaLog>(), ref flagError); //Destrabo sat y traigo la respuesta de las prensas fallidas de la bd
                        break;
                    case 4:
                        ListPrensasAct = new BdDestrSat().SP_DestrabaSat4(new List<PrensaLog>(), ref flagError); //Destrabo sat y traigo la respuesta de las prensas fallidas de la bd
                        break;
                }

                if (ListPrensasAct.Count>0 )
                    ListPrensasAnt = ListPrensasAct;   // Guardo el valor de la lista anterior antes de volver a actualizar su valor si no es la ultima lista (porque la ultima lista siempre esta vacia)
                                        
                CantPren = ListPrensasAct.Count;
            }
            Console.WriteLine("Destrabado" + nroSat);
            new DestrabarPrensa().EscribirLog(ListPrensasAnt, nroSat);
            return ListPrensasAnt;
        }

        public void EscribirLog(List<PrensaLog> logs, int nroSat )
        {
            Log oLog = new Log(@".\");
            oLog.Add("Lista de prensas con fallas del satelite" + nroSat + ": ");
            foreach (var prensa in logs)
            {
                
                oLog.Add(prensa.Press.ToString());
               
            }
        }

        public string ConvertirAtexto(List<PrensaLog> logs)
        {
           

            StringBuilder oLog = new StringBuilder();


            oLog.Append("Record_id  ");
            oLog.Append("Press  ");
            oLog.Append("Item0  ");
            oLog.Append("Item1  ");
            oLog.Append("Item2  ");
            oLog.Append("Item3  ");
            oLog.Append("Item4  ");
            oLog.Append("Item5  ");
            oLog.Append("Item6  ");
            oLog.Append("Item7  ");
            oLog.Append("Item8  ");
            oLog.Append("Item9  ");
            oLog.Append("Item10  ");
            oLog.Append("Item11  ");
            oLog.Append("Item12  ");
            oLog.Append("Item13  ");
            oLog.Append("Item14  ");
            oLog.Append("Item15  ");
            oLog.Append("Packet  ");
            oLog.Append("Status  ");
            oLog.Append("Attempts  ");
            oLog.Append("Insert_date" + Environment.NewLine);

            foreach (var prensa in logs)
            {
                oLog.Append(prensa.Record_id.ToString()+ "  ");
                oLog.Append(prensa.Press.ToString() + "  ");
                oLog.Append(prensa.Item0.ToString() + "  ");
                oLog.Append(prensa.Item1.ToString() + "  ");
                oLog.Append(prensa.Item2.ToString() + "  ");
                oLog.Append(prensa.Item3.ToString() + "  ");
                oLog.Append(prensa.Item4.ToString() + "  ");
                oLog.Append(prensa.Item5.ToString() + "  ");
                oLog.Append(prensa.Item6.ToString() + "  ");
                oLog.Append(prensa.Item7.ToString() + "  ");
                oLog.Append(prensa.Item8.ToString() + "  ");
                oLog.Append(prensa.Item9.ToString() + "  ");
                oLog.Append(prensa.Item10.ToString() + "  ");
                oLog.Append(prensa.Item11.ToString() + "  ");
                oLog.Append(prensa.Item12.ToString() + "  ");
                oLog.Append(prensa.Item13.ToString() + "  ");
                oLog.Append(prensa.Item14.ToString() + "  ");
                oLog.Append(prensa.Item15.ToString() + "  ");
                oLog.Append(prensa.Packet.ToString() + "  ");
                oLog.Append(prensa.Status.ToString() + "  ");
                oLog.Append(prensa.Attempts.ToString() + "  ");
                oLog.Append(prensa.Insert_date.ToString() + Environment.NewLine);
            }

             return oLog.ToString();
        }

        public string LstPrensFalla (List<PrensaLog> log)
        {
            string strPren = "Las prensas con error: ";
            foreach (var item in log)
            {
                strPren += item.Press.ToString() + " ";
            }
            return strPren;
        }
    }
}



