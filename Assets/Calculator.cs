using UnityEngine;

public class Calculator : MonoBehaviour
{
    [SerializeField] float number1;
    [SerializeField] float number2;

    [SerializeField] float sum;
    [SerializeField] float difference;
    [SerializeField] float product;
    [SerializeField] float ratio;

    void OnValidate ()
    {
        sum = number1 + number2;
        difference = number1 - number2;
        product = number1 * number2;
        ratio = number1 / number2;
    }
}

