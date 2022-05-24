using UnityEngine;

public class Distance : MonoBehaviour
{

    [SerializeField] Transform obj1;
    [SerializeField] Transform obj2;

    [SerializeField] float distance;

    void OnValidate()
    {
        Vector3 dif = obj1.position - obj2.position;
        distance = dif.magnitude;

    }


}
