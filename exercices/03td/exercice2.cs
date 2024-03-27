using System;

namespace _03td {
        public static class Exercice2 {
        // Exercices 2
                public static void ShuffleArray(int[] array) {
                Random shuffle = new Random();
                for (int i = 0; i < array.Length; i++) {
                        int selectRandomIndex = shuffle.Next(array.Length);
                        int nextArray = array[i];
                        array[i] = array[selectRandomIndex];
                        array[selectRandomIndex] = nextArray;
                }
        }
        }
}