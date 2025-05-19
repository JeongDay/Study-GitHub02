using UnityEngine;

public class RouletteController : MonoBehaviour
{
    public float rotSpeed;
    private bool isStop, isRotating = false;
    
    void Update()
    {
        this.transform.Rotate(0f, 0f, rotSpeed);
        
        if (Input.GetMouseButtonDown(0))
        {
            rotSpeed = 5f;
            isRotating = true;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isRotating)
            {
                isStop = true;
            }
        }
        
        if (isStop)
        {
            rotSpeed *= 0.98f;

            if (rotSpeed <= 0.1f)
            {
                rotSpeed = 0f;
                isRotating = false;
                isStop = false;
            }
        }
    }
}