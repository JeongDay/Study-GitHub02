using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MaterialStudy : MonoBehaviour
{
    public string hexCodeColor;
    
    void Start()
    {
        Material newMat = this.GetComponent<MeshRenderer>().material;
        Color color;
        
        if (ColorUtility.TryParseHtmlString(hexCodeColor, out color))
        {
            newMat.color = color;
        }
    }
}