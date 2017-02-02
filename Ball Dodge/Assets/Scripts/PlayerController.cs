using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerController : MonoBehaviour
{
    public float speed;
    private Rigidbody rb;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Vertical");
        float moveVertical = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector3(-1.0f, 0.0f, moveVertical);
        rb.AddForce(movement * speed);
    }
void OnTriggerEnter(Collider other)
{
    if (other.tag == "Wall")
    {
        Time.timeScale = 0;
    }
}
}

