using System;

namespace Aquarium {
    class Program {
        public static void Main() {
            
        }
    }

    class AquariumCalculator {
        static double CalculateVolume(int length, int height) {
            Math.Pow((double)length * (double)height, 3) / 1000;
        }
    }
}