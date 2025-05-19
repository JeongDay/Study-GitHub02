using UnityEngine;

public class ComponentStudy : MonoBehaviour
{
    public Mesh mesh;
    public Material mat;
    
    void Start()
    {
        GameObject newObj = new GameObject("New GameObject");
        
        newObj.AddComponent<MeshFilter>();
        newObj.AddComponent<MeshRenderer>();
        newObj.AddComponent<BoxCollider>();

        newObj.GetComponent<MeshFilter>().mesh = mesh;
        newObj.GetComponent<MeshRenderer>().material = mat;
    }
}