using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente___Observer
{
    public class FloraObserver : IObserver
    {
        private int totalElementosFlora = 0;
        
      
        public void Actualizar(Isubject hab)
        {
            if ((hab as Habitante).Tipo == "Flora")
            {
                totalElementosFlora++;
                MessageBox.Show("Total Flora" + totalElementosFlora);
            }
        }

    }
}
