using UnityEngine;

public class Study_Class
{
    public int number;

    public Study_Class(int _number)
    {
        this.number = _number;
    }
}

public struct Study_Struct
{
    public int number;

    public Study_Struct(int _number)
    {
        this.number = _number;
    }
}

public class Study_ClassStruct : MonoBehaviour
{
    void Start()
    {
        Debug.Log("클래스 얕은 복사-----------------------");
        Study_Class c1 = new Study_Class(10);
        Study_Class c2 = c1; // 얕은 복사
        Debug.Log("c1 : " + c1.number + " / c2 : " + c2.number);

        c1.number = 100;
        Debug.Log("c1 : " + c1.number + " / c2 : " + c2.number); // 둘 다 100
        
        Debug.Log("클래스 깊은 복사-----------------------");
        Study_Class c3 = new Study_Class(20);
        Study_Class c4 = new Study_Class(c3.number); // 깊은 복사
        Debug.Log("c3 : " + c3.number + " / c4 : " + c4.number);

        c3.number = 200;
        Debug.Log("c3 : " + c3.number + " / c4 : " + c4.number); // c4는 그대로 20
        
        Debug.Log("구조체-----------------------");
        Study_Struct s1 = new Study_Struct(10);
        Study_Struct s2 = s1;
        Debug.Log($"s1 : {s1.number} / s2 : {s2.number}");
        
        s1.number = 100;
        Debug.Log($"s1 : {s1.number} / s2 : {s2.number}");
    }
}