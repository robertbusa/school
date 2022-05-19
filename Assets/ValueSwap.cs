using UnityEngine;

public class ValueSwap : MonoBehaviour
{
    [SerializeField] string text1 = "AAA";
    [SerializeField] string text2 = "BBB";

    void Start()
    {
        string temp = text1;
        text1 = text2;
        text2 = temp;
    }

}
