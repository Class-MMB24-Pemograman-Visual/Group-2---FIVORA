using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20f;
    public float turnSpeed = 50f;
    private float horizontalInput;
    private float verticalInput;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        Vector3 moveDirection = transform.forward * verticalInput * speed * Time.fixedDeltaTime;
        rb.MovePosition(rb.position + moveDirection);

        Quaternion turn = Quaternion.Euler(0f, horizontalInput * turnSpeed * Time.fixedDeltaTime, 0f);
        rb.MoveRotation(rb.rotation * turn);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Box"))
        {
            Rigidbody boxRb = collision.rigidbody;
            if (boxRb != null)
            {
                boxRb.AddForce(transform.forward * 500f);
            }
        }
    }
}
