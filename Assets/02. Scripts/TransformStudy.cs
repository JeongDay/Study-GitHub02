using UnityEngine;
 
 public class TransformStudy : MonoBehaviour
 {
     public float moveSpeed = 3f;
     
     void Update()
     {
         if (Input.GetKey(KeyCode.RightArrow))
         {
             this.transform.position += Vector3.right * Time.deltaTime * moveSpeed;
         }
         else if (Input.GetKey(KeyCode.LeftArrow))
         {
             this.transform.position += Vector3.left * Time.deltaTime * moveSpeed;
         }
 
         if (Input.GetKey(KeyCode.LeftShift))
         {
             moveSpeed = 6f;
         }
         else if (Input.GetKeyUp(KeyCode.LeftShift))
         {
             moveSpeed = 3f;
         }
     }
 }