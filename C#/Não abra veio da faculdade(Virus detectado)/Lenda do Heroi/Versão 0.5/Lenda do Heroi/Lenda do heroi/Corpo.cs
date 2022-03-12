using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lenda_do_heroi
{
    internal class Corpo
    {
        public string cabeca;
        public string torso;
        public string maos;
        public string pernas;
        public  string pes;
        public Corpo(string cabeca,string torso, string maos, string pernas, string pes)
        {
            this.cabeca = cabeca;
            this.torso = torso;
            this.maos = maos;
            this.pernas = pernas;
            this.pes = pes;
        }
    }
}
