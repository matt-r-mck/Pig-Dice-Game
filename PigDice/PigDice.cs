using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace PigDice {
    class PigDice {

        Random rnd = new Random();

        int Roll() {
            return rnd.Next(1, 7);
        }

        public int Play() {
            var die = Roll();
            var total = 0;
            while (die != 1) {
                total += die;
                die = Roll();
            }
                return total;
            }
        }

    }
