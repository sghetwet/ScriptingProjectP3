using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruitys
{

    public Fruitys()
    {
        Debug.Log("1st Fruit Constuctor Called");
    }

    public virtual void Chop()
    {
        Debug.Log("the fruit has been chopped.");
    }

    public virtual void SayHello()
    {
        Debug.Log("Hello, I am fruit.");
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
