using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Onager : Enemy
{

    // Use this for initialization
    void Start()
    {
        base.Start();
        speed = 2.5F;
        target = transform.position + new Vector3(13, 0, 0);
        lives = 6;
    }
}
