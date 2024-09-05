using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Speed : PowerUp
{
    public string speedID;

    public override string ID => speedID;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Use();
    }

  
    public override void Use()
    {
        transform.position += new Vector3(-0.1f, 0, 0);
        Debug.Log("Power up has been used");
    }
}
