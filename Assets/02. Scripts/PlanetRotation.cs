using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    public float rotSpeed = 30f;

    void Update()
    {
        this.transform.Rotate(Vector3.up * Time.deltaTime * rotSpeed);
    }
}