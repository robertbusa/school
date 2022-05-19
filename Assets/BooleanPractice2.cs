using UnityEngine;

public class BooleanPractice2 : MonoBehaviour
{
    [SerializeField] string FamilyName;
    [SerializeField] string FirstName;
    [SerializeField] int bornYear;
    [SerializeField] int height;
    [SerializeField] bool isSnoring;

    [SerializeField] bool blabla;
    [SerializeField] bool krixkrax;

    void OnValidate()
    {
        bool isHeightRight = height > 165 && height < 200;
        bool isAgeRight = bornYear >= 2000;
        blabla = isHeightRight && isAgeRight && !isSnoring;

        isHeightRight = height < 180 || height < 210;
        bool isNameRight = FamilyName == FirstName;
        krixkrax = isHeightRight || isNameRight;
    }

    void Update()
    {
        
    }
}
