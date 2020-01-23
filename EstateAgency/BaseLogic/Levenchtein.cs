using System;

namespace EstateAgency.BaseLogic
{
    class Levenchtein
    {
        /// <summary>
        /// Возвращает расстояние Левенштейна между двумя словами. 
        /// Порядок слов не важен.
        /// </summary>
        public static int Length(string word1, string word2)
        {
            if (word1.Length == 0 && word2.Length == 0)
            {
                return 0;
            }

            if (word1.Length == 0 && word2.Length > 0)
            {
                return word2.Length;
            }

            if (word1.Length > 0 && word2.Length == 0)
            {
                return word1.Length;
            }

            int diff;
            int[,] matrix = new int[word1.Length + 1, word2.Length + 1];

            for (int i = 0; i <= word1.Length; i++)
                matrix[i, 0] = i;
            for (int j = 0; j <= word2.Length; j++)
                matrix[0, j] = j;

            for (int i = 1; i <= word1.Length; i++)
            {
                for (int j = 1; j <= word2.Length; j++)
                {
                    diff = (word1[i - 1] == word2[j - 1]) ? 0 : 1;

                    matrix[i, j] = Math.Min(Math.Min(matrix[i - 1, j] + 1,
                                             matrix[i, j - 1] + 1),
                                             matrix[i - 1, j - 1] + diff);
                }
            }

            return matrix[word1.Length, word2.Length];
        }
    }
}
