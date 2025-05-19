using UnityEngine;

public class SetMaterialColor : MonoBehaviour
{
    public Material mat;
    public Color color;
    
    void Start()
    {
        // this.GetComponent<MeshRenderer>().material = mat;
        // this.GetComponent<MeshRenderer>().material.color = color;
        // this.GetComponent<MeshRenderer>().material.color = Color.green;
        // this.GetComponent<MeshRenderer>().sharedMaterial.color = Color.green;
    }
}