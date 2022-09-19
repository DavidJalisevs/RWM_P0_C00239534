using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeFilter
{


    public static int[] Module3(int[] xs)
    {
        int[] result = new int[xs.Length];


        for (int i = 0; i < xs.Length; i++)
        {
            result[i] = xs[i] % 3;

        }
        return result;
    }



}
