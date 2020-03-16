using System;

namespace MyExercises.Helpers
{
    public class ExampleHelper
    {
        public int[] ArrayExample01(ref int[] numbers)
        {
            int latestItem = numbers[0];
            bool duplicated = false;
            int duplicatedCount = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (duplicated && (numbers[i] != latestItem))
                {
                    duplicated = false;
                    latestItem = numbers[i];
                }

                if (duplicated && (numbers[i] == latestItem))
                {                    
                    numbers[i] = 0;
                    duplicatedCount++;
                }

                if (!duplicated && (numbers[i] == latestItem))
                {
                    duplicated = true;                    
                }
            }

            int[] newArray = new int[numbers.Length - duplicatedCount];
            int newArrayCount = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] != 0)
                {
                    newArray[newArrayCount] = numbers[i];
                    newArrayCount++;
                }
            }
            return newArray;
        }



    }
}