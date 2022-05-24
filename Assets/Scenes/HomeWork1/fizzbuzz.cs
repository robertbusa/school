using UnityEngine;

public class FizzBuzz : MonoBehaviour
{

    [SerializeField] int num;

    void Start()
    {
        for(int i = 1 ; i <= 10; i++)
        {
            if (i % 3 == 0 && i % 5 == 0)
                Debug.Log("fizzbuzz");
            else if (i % 3 == 0)
                Debug.Log("buzz");
            else if (i % 5 == 0)
                Debug.Log("fizz");
            else
                Debug.Log(i);
        }
    }


}
