using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazyn
{
    interface IProdukt
    {
        string Nazwa { get; }
        decimal Cena { get; }
        int Ilość { get; }
        DateTime DataProdukcji { get; }
        DateTime DataWażności { get; }
    }
}
