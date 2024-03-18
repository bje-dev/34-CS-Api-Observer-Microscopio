using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cliente___Observer
{
    public class Habitante : Isubject
    {
        public string Nombre { get; set; }
        public string Color { get; set; }
        public string Tamaño { get; set; }
        public string Tipo { get; set; }

        //public int State { get; set; } = -0;

        private List<IObserver> observadores = new List<IObserver>();

        public void RegistrarObservador(IObserver observador)
        {
            MessageBox.Show("Subject: Attached an observer.");
            this.observadores.Add(observador);
        }

        public void QuitarObservador(IObserver observador)
        {
            this.observadores.Remove(observador);
            MessageBox.Show("Subject: Detached an observer.");
        }

        public void NotificarResultado()
        {
           // MessageBox.Show("Subject: Notifying observers...");
           
            foreach (var observador in observadores)
            {
                observador.Actualizar(this);
            }
        }


        public void SomeBusinessLogic()
        {
         
            //this.State = new Random().Next(0, 10);
            //MessageBox.Show("Subject: Mi estado ha sido cambiado a: " + this.Tipo);
            this.NotificarResultado();
        }
        


    }
}
