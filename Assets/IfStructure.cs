using UnityEngine;

public class IfStructure : MonoBehaviour
{
    [SerializeField] float characterHeight;
    [SerializeField] float enemy1Heght;
    [SerializeField] float enemy2Height;

    [SerializeField] bool areWeWinning;
    [SerializeField] string state;

    void OnValidate()
    {
        areWeWinning = characterHeight > enemy1Heght && characterHeight > enemy2Height;

        state = areWeWinning ? "Winning" : "Loosing";

        if (areWeWinning)
        {
            Debug.Log("WINNING");

        }
        else
        {
            Debug.Log("LOOSING");

        }


    }

}
