using UnityEngine;

public class VectorPractice : MonoBehaviour
{
    [SerializeField] Vector2 inputV2_1;
    [SerializeField] Vector2 inputV2_2;
    [SerializeField] float multiplier;
    [SerializeField] Vector2 summa;
    [SerializeField] Vector2 diference;

    [SerializeField] Vector3 inputV3;
    [SerializeField] Vector2 outputV2;
    [SerializeField] Vector3 outputV3;


    void OnValidate()
    {
        float f = 34.67f;

        Vector2 v2 = new Vector2(2, 3.5f);
        Vector3 v3 = new Vector3(3, 5, -7);

        Vector3 v3_1 = v2;
        outputV3 = inputV2_2;
        outputV2 = inputV3;

        summa = inputV2_1 + inputV2_2;
        diference = inputV2_1 - inputV2_2;

    }

}
