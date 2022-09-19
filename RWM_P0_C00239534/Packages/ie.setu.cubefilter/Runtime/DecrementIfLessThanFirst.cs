using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DecrementIfLessThanFirst
{
  

    public static int[] DecrementIfLessThanFirstPass(int[] xs)
    {
        int[] result = new int[xs.Length];

        int firstNum = 0;
        int check = 0;
        for (int i = 0; i < xs.Length; i++)
        {
            result[i] = xs[i];

            if (check == 0)
            {
                firstNum = xs[i];
            }
            check = 1;


            if (firstNum > xs[i])
            {
                result[i] -= 1;
            }

        }
        return result;
    }
}
