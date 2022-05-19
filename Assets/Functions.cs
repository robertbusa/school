using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour
{

    [SerializeField] int a;
    [SerializeField] int b;

    [SerializeField] int max;
    [SerializeField] int min;
    [SerializeField] int abs;

    void OnValidate()
    {
        max = Mathf.Max(a, b);
        min = Mathf.Min(a, b);
        abs = AbsoluteValue(a);
       // abs = Mathf.Abs(a);
    }

    int AbsoluteValue(int input)
    {
        if (input <= 0)
            return input;
        else
            return -input;

    }
}
