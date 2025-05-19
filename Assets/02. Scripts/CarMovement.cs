using UnityEngine;

public class CarMovement : MonoBehaviour
{
    private Rigidbody2D carRb;
    
    public float moveSpeed = 3f;
    private float h;

    void Start()
    {
        carRb = this.GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        h = Input.GetAxis("Horizontal");
    }

    void FixedUpdate()
    {
        if (h != 0)
            carRb.linearVelocityX = h * moveSpeed;
        else
            carRb.linearVelocityX = 0f;
    }
}