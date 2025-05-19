using UnityEngine;

public class StudyMath : MonoBehaviour
{
    void Start()
    {
        // 각도(Degree) -> 라디안(Radian)
        // Mathf.Deg2Rad

        // 라디안(Radian) -> 각도(Degree)
        // Mathf.Rad2Deg
            
        float degree = 180f;
        float rad = degree * Mathf.Deg2Rad;

        Debug.Log(rad);
    }
}