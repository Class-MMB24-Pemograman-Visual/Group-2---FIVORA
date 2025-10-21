using UnityEngine;

public class AICarController : MonoBehaviour
{
    public float speed = 10f;

    void Update()
    {
        
        transform.Translate(Vector3.forward * Time.deltaTime * speed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        
        if (collision.gameObject.CompareTag("Box") || collision.gameObject.CompareTag("Car"))
        {
            transform.Translate(Vector3.back * Time.deltaTime * 25f);
        }
    }
}
