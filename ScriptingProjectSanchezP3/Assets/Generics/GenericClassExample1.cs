using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericClassExample1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GenericClass123<int> myClass = new GenericClass123<int>();

        myClass.UpdateItem(5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
