using UnityEngine;

public class TransformMove : MonoBehaviour
{
    public float moveSpeed = 5f;
    
    private float h = 0f;
    private float v = 0f;

    void Update()
    {
        // GetAxisRaw : -1, 0, 1
        h = Input.GetAxisRaw("Horizontal");
        v = Input.GetAxisRaw("Vertical");
        
        Vector3 dir = new Vector3(h, 0f, v).normalized;
        Debug.Log(dir);

        this.transform.Translate(dir * Time.deltaTime * moveSpeed);
    }
}