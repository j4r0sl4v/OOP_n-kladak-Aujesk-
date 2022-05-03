using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_vozidla_Aujeský
{
    public class Nakladak
    {
        public string název = "";
        public int nosnost { get; set; }
        
        public int Spotřeba_Nádrže { get; set; }
       
        public int ObjemNadrze { get; set; }
        
        public int CelkováVzdalenost { get; set; } 

        public int náklad { get; set; }

        public Nakladak()
        {
            název = "";
            nosnost = 25000;
            náklad = 0;
            ObjemNadrze = 1000;
            Spotřeba_Nádrže = 25;
            CelkováVzdalenost = 0;
        }

        public void jet()
        {
            CelkováVzdalenost += 100;
            ObjemNadrze -= 25;
            if (ObjemNadrze <= 0)
            {
                ObjemNadrze = 0;
                CelkováVzdalenost += 0;
            }
        }
    }
}
