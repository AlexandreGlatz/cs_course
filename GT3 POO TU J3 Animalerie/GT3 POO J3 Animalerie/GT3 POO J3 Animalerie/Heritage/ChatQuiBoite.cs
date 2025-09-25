using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge.Heritage
{
    public class ChatQuiBoite : Chat
    {
        public ChatQuiBoite(string name) : base(name)
        {
            _pattes = 3;
        }

        public override string Crier()
        {
            return base.Crier();
        }

        public override void Die()
        {
            base.Die();
        }
    }
}
