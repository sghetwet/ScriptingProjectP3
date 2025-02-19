using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericClass123 <T>
{
    T item;

    public void UpdateItem(T newItem)
    {
        item = newItem;
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
