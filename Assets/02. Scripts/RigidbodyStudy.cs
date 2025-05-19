using UnityEngine;

public class RigidbodyStudy : MonoBehaviour
{
    public float moveSpeed = 3f;
    
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.GetComponent<Rigidbody2D>().linearVelocity = Vector3.right * moveSpeed;
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.GetComponent<Rigidbody2D>().linearVelocity = Vector3.left * moveSpeed;
        }
        else
        {
            this.GetComponent<Rigidbody2D>().linearVelocity = Vector3.zero;
        }

        if (Input.GetKey(KeyCode.LeftShift))
        {
            moveSpeed = 6f;
        }
        else if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            moveSpeed = 3f;
        }
    }
}