using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente___Observer
{
    public interface Isubject
    {
        // Attach an observer to the subject.
        void RegistrarObservador(IObserver observador);

        // Detach an observer from the subject.
        void QuitarObservador(IObserver observador);

        // Notify all observers about an event.
        void NotificarResultado();
    }
}
