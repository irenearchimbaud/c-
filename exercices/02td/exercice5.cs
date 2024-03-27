using System;

namespace _02td {
    public static class Exercice5
    {
        // Exercices 5
        public static int AddNFirstNumbers(int myNumber){
            int calculateNumber = 0;
            for (int i = 1; i <= myNumber; i++){
                calculateNumber = calculateNumber + i;
            }
            return calculateNumber;
        }
    }
}