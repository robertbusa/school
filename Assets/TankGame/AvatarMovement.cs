using UnityEngine;

public class AvatarMovement : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float angularSpeed;


    void Update()
    {
        bool right = Input.GetKey(KeyCode.RightArrow);
        bool left = Input.GetKey(KeyCode.LeftArrow);
        bool up = Input.GetKey(KeyCode.UpArrow);
        bool down = Input.GetKey(KeyCode.DownArrow);

        float x = right ? 1 : (left ? -1 : 0);
        float z = up ? 1 : (down ? -1 : 0);

        Vector3 inputVector = new Vector3(x, 0, z);

        if (inputVector != Vector3.zero)

        {
            transform.position += inputVector.normalized * Time.deltaTime * speed;

            // az inputvector normaliz�lva minden ir�nyba ugyanolyan sebess�ggel halad.
            // a time.deltatime a g�p sebess�g�hez alkalmazva 60 fps, vagy 30ps l�pteti a karaktert ugyan�gy 1 egys�ggel mindig

            Quaternion targetRotation =
                Quaternion.LookRotation(inputVector);
            Quaternion resultRotation = Quaternion.RotateTowards
                    (transform.rotation, targetRotation, angularSpeed * Time.deltaTime);

            transform.rotation = resultRotation;
        }


    }

}
