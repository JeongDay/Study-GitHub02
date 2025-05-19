using UnityEngine;

public class PinballController : MonoBehaviour
{
    public Rigidbody2D leftStickRb;
    public Rigidbody2D rightStickRb;
    
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
            leftStickRb.AddTorque(30f);
        else
            leftStickRb.AddTorque(-25f);
        
        if (Input.GetKey(KeyCode.RightArrow))
            rightStickRb.AddTorque(-30f);
        else
            rightStickRb.AddTorque(25f);
    }
}