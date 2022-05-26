using UnityEngine;

public class FollowerEnemy : MonoBehaviour
{
    [SerializeField] Transform followable;
    [SerializeField] AnimationCurve speedFunction;

    void Update()
    {
                
        Vector3 targetPos = followable.position;

        float distance = Vector3.Distance(targetPos, transform.position);
        float speed = speedFunction.Evaluate(distance);


        float maxDistance = Time.deltaTime * speed;

        // Vector3 movementVector = targetPos - transform.position;
        // transform.position += movementVector.normalized * Time.deltaTime * speed;


        transform.position = Vector3.MoveTowards(transform.position, targetPos, maxDistance);

        Vector3 movementVector = targetPos - transform.position;

        if(movementVector != Vector3.zero)
            transform.rotation = Quaternion.LookRotation(movementVector);




    }

}
