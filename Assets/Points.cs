using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Points : PowerUp
{
    // Start is called before the first frame update

    public string pointsId;

    public override string ID => pointsId;
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
        transform.position += new Vector3(0.21f, 0.001f);
    }
}
