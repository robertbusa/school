using UnityEngine;

public class Pythagorian : MonoBehaviour
{
    [SerializeField] int a;
    [SerializeField] int b;
    [SerializeField] int c;
    [Space]
    [SerializeField] bool isPythagorian;

    void OnValidate()
    {
        isPythagorian = (a * a) + (b * b) == (c * c);
    }

}
