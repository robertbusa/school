using UnityEngine;

public class PathMovingObstacle : MonoBehaviour
{
    [SerializeField] Transform point1;
    [SerializeField] Transform point2;
    [SerializeField] float speed;

    [SerializeField, Range(0, 1)] float t;

    bool movingUp;

    void OnValidate()
    {
        UpdatePosition();
    }
    void Update()
    {
        float distance = Vector3.Distance(point1.position, point2.position);

        if (movingUp)
        {
            t += Time.deltaTime / distance * speed;
            if (t > 1)
                movingUp = false;
        }
        else
        {
            t -= Time.deltaTime / distance * speed;
            if (t < 0)
                movingUp = true;


        }

        UpdatePosition(); // mindig a végén updatelje a poziciót
    }

    void UpdatePosition()
    {
        transform.position = Vector3.Lerp(point1.position, point2.position, t);
    }

    void OnDrawGizmos()
    {
        // gizmokkal kijelölünk magunkna helyeket, ahol mozog az object
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(point1.position,0.2f);
        Gizmos.DrawWireSphere(point2.position, 0.2f);
        Gizmos.DrawLine(point1.position, point2.position); // vonalat húz a két pont közé

    }

    
}

