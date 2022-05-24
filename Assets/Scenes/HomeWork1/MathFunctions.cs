using UnityEngine;

public class MathFunctions : MonoBehaviour
{
    // Ha az input pozitív szám, akkor 1 lesz, ha negatív, akkor -1
    [SerializeField] float signInput;
    [SerializeField] float signOutput;

    void OnValidate()
    {
        if (signInput >= 0)
        {
            signOutput = 1;
        }
        else
        {
            signOutput = -1; 

        }
    }

    float Sign(float input)
    {
        if (input >= 0)
        {
            return 1;
        }
        else
        {
            return -1;
        }
    }

    float AbsolutValue(float input)
    {
        if (input >= 0)
        {
            return input;
        }
        else
        {
            return input * -1; // return -input;

        }
    }

    float Ceiling(float input)

    {
        if (input % 1 == 0)
        {
            return input;
        }
        else
        {
            float remainder = input % 1;
            return input + (1 - remainder);
        }


    }
    void Start()
    {
        // Szemléltetésképpen: 
       float signResult1 = Mathf.Sign(-45); // -1
        float absResult1 = Mathf.Abs(-45);  // 45

        float original = signResult1 * absResult1;

    }


}
