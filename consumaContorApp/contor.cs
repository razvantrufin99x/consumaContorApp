using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace consumaContorApp
{
    public class contor
    {
        public string idcontor;
        public int indexulactual = -1;
        public List<float> citiriContor = new List<float>();
        public float valoareactuala=0;
        public float valoareprecedenta=0;
        public string tipcontor;

        public contor (string pidcontor ,string ptipcontor){
            idcontor = pidcontor;
            tipcontor = ptipcontor;
        }
        public  float citireContor() { return valoareactuala; }
        public void  inregistrareContor(float valoarenoua) {
            indexulactual++;
            citiriContor.Add(valoarenoua);
            valoareprecedenta = valoareactuala;
            valoareactuala = valoarenoua;
           
        
        }

        public bool amersinapoi() {
            if (valoareactuala - valoareprecedenta < 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public float diferentadintreultimeledouacitiri()
        {

            if (valoareactuala - valoareprecedenta >= 0 && amersinapoi() == false)
            {
                return valoareactuala - valoareprecedenta;
            }
            else { return -1; }
           
           
        }
        //salveazadate
        //incarcadate

       
    }
}
