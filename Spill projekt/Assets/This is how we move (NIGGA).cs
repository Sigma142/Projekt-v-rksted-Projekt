using UnityEngine;

public class Thisishowwemove : MonoBehaviour
{
    Vector3 velocity;
    public float gravity = -1f;
    public float Jumpheight = 2f;
    public float moveSpeed = 5f;
    public Transform cameraTransform;

    private CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
        
    }

    void Update()
    {
        //movment
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 forward = cameraTransform.forward;
        Vector3 right = cameraTransform.right;

        forward.y = 0f;
        right.y = 0f;
        forward.Normalize();
        right.Normalize();

        Vector3 moveDirection = forward * vertical + right * horizontal;

        controller.Move(moveDirection * moveSpeed * Time.deltaTime);

        //gravity
        if (controller.isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

        // jump
        if (Input.GetButtonDown("Jump")  && controller.isGrounded) 
        {
            velocity.y = Mathf.Sqrt(Jumpheight * -2f * gravity);
        }
    }
}
