using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 10.0f;
    public float xRange = 15.0f;

    public GameObject projectilePrefab;
    public Transform launchPoint; // ← Titik keluarnya pizza

    void Update()
    {
        // Batas kiri-kanan
        if (transform.position.x < -xRange)
        {
            transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if (transform.position.x > xRange)
        {
            transform.position = new Vector3(xRange, transform.position.y, transform.position.z);
        }

        // Gerakan horizontal
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);

        // Menembak pizza
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Instantiate(projectilePrefab, launchPoint.position, launchPoint.rotation);
        }
    }
}
