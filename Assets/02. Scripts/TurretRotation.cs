using UnityEngine;

public class TurretRotation : MonoBehaviour
{
    public Transform turretHead;
    
    private float theta;
    public float rotRange = 60f;
    public float rotSpeed = 1f;
    
    void Update()
    {
        theta += Time.deltaTime * rotSpeed;

        turretHead.localRotation = Quaternion.Euler(Vector3.up * rotRange * Mathf.Sin(theta));
    }
}
