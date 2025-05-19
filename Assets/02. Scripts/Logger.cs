using UnityEngine;

public class Logger : MonoBehaviour
{
    void Start()
    {
        Debug.Log("Log");
        Debug.LogWarning("LogWarning");
        Debug.LogError("LogError");
    }

    void Update()
    {
        Debug.Log("Log");
    }
}