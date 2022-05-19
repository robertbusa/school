using UnityEngine;

public class LoopStructures : MonoBehaviour
{
    [SerializeField] int num;
    [SerializeField] int count;

    void OnValidate()
    {
        for (int i = 1; i <= num; i++)
        {
            if (num % i == 0)
                count++;
        }
       
    }

    void Update()
    {
        
    }
}
