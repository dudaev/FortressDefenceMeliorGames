using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatArmySword : Enemy {

	
     void Start () {

        base.Start();
        speed = 3F;
        target = transform.position + new Vector3(13, 0, 0);
        lives = 3;

	}
	
	
}
