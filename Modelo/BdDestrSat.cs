using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Modelo.Model_CCM;

namespace Modelo
{
    public class BdDestrSat
    {

        //Sat1
        public List<PrensaLog> SP_DestrabaSat1()
        {
            List<PrensaLog> listadatos = new List<PrensaLog>();
            using (CCM1Entities db = new CCM1Entities())
            {
                var lst = db.Destraba_CCM();
                foreach (var elementBd in lst)
                {
                    PrensaLog elemento = new PrensaLog
                    {
                        Record_id = elementBd.record_id,
                        Press = elementBd.press,
                        Item0 = elementBd.item0,
                        Item1 = elementBd.item1,
                        Item2 = elementBd.item2,
                        Item3 = elementBd.item3,
                        Item4 = elementBd.item4,
                        Item5 = elementBd.item5,
                        Item6 = elementBd.item6,
                        Item7 = elementBd.item7,
                        Item8 = elementBd.item8,
                        Item9 = elementBd.item9,
                        Item10 = elementBd.item10,
                        Item11 = elementBd.item11,
                        Item12 = elementBd.item12,
                        Item13 = elementBd.item13,
                        Item14 = elementBd.item14,
                        Item15 = elementBd.item15,
                        Packet = elementBd.packet,
                        Status = elementBd.status,
                        Attempts = elementBd.attempts,
                        Insert_date = elementBd.insert_date
                    };

                    listadatos.Add(elemento);
                }
            }
            return listadatos;
        }

        //Sat2
        public List<PrensaLog> SP_DestrabaSat2()
        {
            List<PrensaLog> listadatos = new List<PrensaLog>();
            using (CCM2Entities db = new CCM2Entities())
            {
                var lst = db.Destraba_CCM();
                foreach (var elementBd in lst)
                {
                    PrensaLog elemento = new PrensaLog
                    {
                        Record_id = elementBd.record_id,
                        Press = elementBd.press,
                        Item0 = elementBd.item0,
                        Item1 = elementBd.item1,
                        Item2 = elementBd.item2,
                        Item3 = elementBd.item3,
                        Item4 = elementBd.item4,
                        Item5 = elementBd.item5,
                        Item6 = elementBd.item6,
                        Item7 = elementBd.item7,
                        Item8 = elementBd.item8,
                        Item9 = elementBd.item9,
                        Item10 = elementBd.item10,
                        Item11 = elementBd.item11,
                        Item12 = elementBd.item12,
                        Item13 = elementBd.item13,
                        Item14 = elementBd.item14,
                        Item15 = elementBd.item15,
                        Packet = elementBd.packet,
                        Status = elementBd.status,
                        Attempts = elementBd.attempts,
                        Insert_date = elementBd.insert_date
                    };

                    listadatos.Add(elemento);
                }
            }
            return listadatos;
        }





        //Sat3
        public List<PrensaLog> SP_DestrabaSat3()
        {
            List<PrensaLog> listadatos = new List<PrensaLog>();
            using (CCM3Entities db = new CCM3Entities())
            {
                var lst = db.Destraba_CCM();
                foreach (var elementBd in lst)
                {
                    PrensaLog elemento = new PrensaLog
                    {
                        Record_id = elementBd.record_id,
                        Press = elementBd.press,
                        Item0 = elementBd.item0,
                        Item1 = elementBd.item1,
                        Item2 = elementBd.item2,
                        Item3 = elementBd.item3,
                        Item4 = elementBd.item4,
                        Item5 = elementBd.item5,
                        Item6 = elementBd.item6,
                        Item7 = elementBd.item7,
                        Item8 = elementBd.item8,
                        Item9 = elementBd.item9,
                        Item10 = elementBd.item10,
                        Item11 = elementBd.item11,
                        Item12 = elementBd.item12,
                        Item13 = elementBd.item13,
                        Item14 = elementBd.item14,
                        Item15 = elementBd.item15,
                        Packet = elementBd.packet,
                        Status = elementBd.status,
                        Attempts = elementBd.attempts,
                        Insert_date = elementBd.insert_date
                    };

                    listadatos.Add(elemento);
                }
            }
            return listadatos;
        }





        //Sat4
        public List<PrensaLog> SP_DestrabaSat4()
        {
            List<PrensaLog> listadatos = new List<PrensaLog>();
            using (CCM4Entities db = new CCM4Entities())
            {
                var lst = db.Destraba_CCM();
                foreach (var elementBd in lst)
                {
                    PrensaLog elemento = new PrensaLog
                    {
                        Record_id = elementBd.record_id,
                        Press = elementBd.press,
                        Item0 = elementBd.item0,
                        Item1 = elementBd.item1,
                        Item2 = elementBd.item2,
                        Item3 = elementBd.item3,
                        Item4 = elementBd.item4,
                        Item5 = elementBd.item5,
                        Item6 = elementBd.item6,
                        Item7 = elementBd.item7,
                        Item8 = elementBd.item8,
                        Item9 = elementBd.item9,
                        Item10 = elementBd.item10,
                        Item11 = elementBd.item11,
                        Item12 = elementBd.item12,
                        Item13 = elementBd.item13,
                        Item14 = elementBd.item14,
                        Item15 = elementBd.item15,
                        Packet = elementBd.packet,
                        Status = elementBd.status,
                        Attempts = elementBd.attempts,
                        Insert_date = elementBd.insert_date
                    };

                    listadatos.Add(elemento);
                }
            }
            return listadatos;
        }





    }
}
