using System;

namespace PigDice {
    class Program {
        static void Main(string[] args) {

            var pigdice = new PigDice();
            var HighScore = 0;
            for(var count = 1; count <= 10000000000; count++) {
                var score =pigdice.Play();
                if (score > HighScore) {
                    HighScore = score;
                }
            }
            Console.WriteLine($"The High Score is {HighScore}");
        }
    }
}
