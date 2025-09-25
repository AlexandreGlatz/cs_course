﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TU_Challenge.Heritage
{
    public class Chien : Animal
    {
        public Chien(string name) : base(name)
        {
            _pattes = 4;
        }

        public override string Crier()
        {
            if (_isFed == false)
                return "Ouaf (j'ai faim)";

            else
                return "Ouaf (viens on joue ?)";
        }

        public override void Die()
        {
            base.Die();
        }
    }
}
