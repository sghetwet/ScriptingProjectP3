using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeClass : MonoBehaviour
{

    public int Add(int num1, int num2)
    {
        return num1 + num2;
    }
    // Start is called before the first frame update
    public string Add(string str1, string str2)
    {
        return str1 + str2;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
