using UnityEngine;

public class BooleanPractice : MonoBehaviour
{
    // input
    [SerializeField] int num1;
    [SerializeField] int num2;

    [Space]
    // output

    [SerializeField] bool isEqual;
    [SerializeField] bool num1IsSmaller;
    [SerializeField] bool num1isHigher;
    [SerializeField] bool num1IsSmallerOrEqual;
    [SerializeField] bool num1IsHigherOrEqual;

    [Header("Or Operator")]
    // Bring washingpowder if it is cheap or big

    [SerializeField] bool isBig;
    [SerializeField] bool isCheap;
    [Space]
    [SerializeField] bool bringWashingPowder;

    [Header ("AND Operator)")]
    [SerializeField] bool havePaprika;
    [SerializeField] bool havePotato;
    [Space]
    [SerializeField] bool canMakePaprikáskrumpli;
    [SerializeField] bool cannotMakePaprikáskrumpli;



    void OnValidate()
    {
        bool a = false;
        bool b = true;

        isEqual = num1 == num2;
        num1IsSmaller = num1 < num2;
        num1isHigher = num1 > num2;
        num1IsSmallerOrEqual = num1 <= num2;
        num1IsHigherOrEqual = num1 >= num2;


        bringWashingPowder = isBig || isCheap;
        canMakePaprikáskrumpli = havePaprika && havePotato;

        cannotMakePaprikáskrumpli = !canMakePaprikáskrumpli;


    }

}
