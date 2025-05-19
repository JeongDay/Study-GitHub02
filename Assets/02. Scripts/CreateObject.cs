using UnityEngine;

public class CreateObject : MonoBehaviour
{
    public GameObject characterPrefab;
    
    void Start()
    {
        GameObject newObj = Instantiate(characterPrefab);

        Destroy(newObj, 3f);
    }
}