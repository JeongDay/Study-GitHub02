using UnityEngine;

[System.Serializable]
public class Flipper
{
    public Rigidbody2D rb;
    public HingeJoint2D hinge;
    public float motorSpeed;
    public float motorReturnSpeed;
    public float maxTorque;
}

public class PinballManager : MonoBehaviour
{
    public Flipper leftFlipper;
    public Flipper rightFlipper;

    void Update()
    {
        HandleFlipper(leftFlipper, Input.GetKey(KeyCode.LeftArrow));
        HandleFlipper(rightFlipper, Input.GetKey(KeyCode.RightArrow));
    }

    void HandleFlipper(Flipper flipper, bool isPressed)
    {
        JointMotor2D motor = flipper.hinge.motor;
        motor.motorSpeed = isPressed ? flipper.motorSpeed : flipper.motorReturnSpeed;
        motor.maxMotorTorque = flipper.maxTorque;
        flipper.hinge.motor = motor;
        flipper.hinge.useMotor = true;
    }
}