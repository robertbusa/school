using UnityEngine;

public class Avarage : MonoBehaviour
{
    [SerializeField] float number1;
    [SerializeField] float number2;
    [SerializeField] float number3;

    [SerializeField] float average;
    

    void OnValidate()
    {
        float summa = number1 + number2 + number3;
        average = summa / 3;
    }
}

