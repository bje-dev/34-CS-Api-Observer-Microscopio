using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace Cliente___Observer
{
    public class FaunaObserver : IObserver
    {
        private int totalElementosFauna = 0;
        

        public void Actualizar(Isubject hab)
        {
            if ((hab as Habitante).Tipo == "Fauna")
            {
                totalElementosFauna++;
                MessageBox.Show("Total fauna: " + totalElementosFauna);


            }
        }

    }
}
