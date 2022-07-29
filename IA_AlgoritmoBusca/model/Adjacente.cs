using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA_AlgoritmoBusca.model
{
    internal class Adjacente
    {
        public int IdAdjacente { get; set; }
        public int IdCidadeOrigem { get; set; }
        public int IdCidadeDestino { get; set; }
        public int DistRodEntreCidades { get; set; }
        public Adjacente()
        {

        }
    }
}
