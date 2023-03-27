using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private float speed = 7.5f;
    public static float jumpForce = 11f;
    private float gravity = 30f;
    private Vector3 moveDirection;
    public static CharacterController controller;
    public static bool teleporting = false;
    private float time = 0.25f;


    private void Awake()
    {
        controller = GetComponent<CharacterController>();
    }

    private void Update()
    {
        if (teleporting)
        {
            time -= Time.deltaTime;
            if (time<=0f)
            {
                teleporting = false;
                time = 0.25f;
            }
        }
        else if (teleporting == false)
        {
            if (controller.isGrounded)
            {
                Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));

                moveDirection.x = move.x * speed;
                moveDirection.z = move.z * speed;

                moveDirection = transform.TransformDirection(moveDirection);

                if (Input.GetKey(KeyCode.Space))
                {
                    moveDirection.y += jumpForce;
                }
            }
            else
            {
                moveDirection.y -= gravity * Time.deltaTime;
            }

            controller.Move(moveDirection * Time.deltaTime);
        }
    }
}