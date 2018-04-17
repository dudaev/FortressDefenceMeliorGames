using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomber : Enemy {

	// Use this for initialization
	void Start () {
        base.Start();
        speed = 2F;
        target = transform.position + new Vector3(10, 0, 0);
        lives = 4;
    }
	
	
}
