using System;
using UnityEngine;

public class Magnitude : MonoBehaviour
{

    [SerializeField] Vector3 vector;
    [SerializeField] float magnitude;
    [SerializeField] float magnitude2; // saját fügvénnyel

    void OnValidate()
    {
        magnitude = vector.magnitude;
        magnitude2 = GetMagnitude(vector);

    }

    float GetMagnitude(Vector2 vector)
    {
        float sqrX = vector.x * vector.x;
        float sqrY = vector.y * vector.y;

        return MathF.Sqrt(sqrX + sqrY);
    }
}
