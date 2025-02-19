using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SomeOtherClass123 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SomeClass123 myClass = new SomeClass123();

        myClass.GenericMethod<int>(5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
