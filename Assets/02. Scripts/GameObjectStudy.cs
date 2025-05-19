using UnityEngine;

public class GameObjectStudy : MonoBehaviour
{
    public string findTag = "Player";

    public GameObject character;

    public Transform[] childObjs;
    
    void Start()
    {
        character = GameObject.FindGameObjectWithTag(findTag);

        childObjs = character.GetComponentsInChildren<Transform>();
        
        
    }
}