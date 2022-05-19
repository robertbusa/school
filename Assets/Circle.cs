using UnityEngine;

public class Circle : MonoBehaviour
{
    [SerializeField] float radius;
    [SerializeField] float circumference;
    [SerializeField] float area;

    void OnValidate()
    {
        float pi = Mathf.PI;
        circumference = 2 * radius * pi;
        area = radius * radius * pi;
        
    }
}

