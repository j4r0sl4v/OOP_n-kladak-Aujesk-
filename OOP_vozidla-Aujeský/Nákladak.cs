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

        public  void MAN()
        {
            název = "";
            nosnost = 25000;
            ObjemNadrze = 1000;
            Spotřeba_Nádrže = 25;
            CelkováVzdalenost = 0;
        }
        public void MERCEDES()
        {
            název = "";
            nosnost = 30000;
            ObjemNadrze = 1500;
            Spotřeba_Nádrže = 50;
            CelkováVzdalenost = 0;
        }

    }
}
