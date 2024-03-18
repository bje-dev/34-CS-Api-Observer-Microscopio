using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cliente___Observer
{
    public interface IObserver
    {
        void Actualizar(Isubject hab);
    }
}
