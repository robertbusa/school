using UnityEngine;

public class PrimeNumbers : MonoBehaviour
{

    void Start()
    {
        int count = 0;
            for (int i = 2; count < 100; i++)
        {
            if (IsPrime(i))
            {
                Debug.Log(i);
                count++;

            }
                    }

    }
    bool IsPrime(int n)
    {
        if (n <= 1)
            return false;

        for (int i = 2; i <= n/2; i++)
        {
            if (n % i == 0)
                return false;  // NEM PRIME
        }
        return true;
    }
}
