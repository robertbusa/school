using UnityEngine;

public class CountingNumbers : MonoBehaviour
{
    [SerializeField] int number;
    [SerializeField] string outputString;

    void OnValidate()
    {
        outputString = "";
        for (int i = 1; i <= number; i++)
        {
            if(i == number)
            outputString = outputString + i;
            else
                outputString = outputString + i + ", ";
        }
    }


}
