using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour {

    Archer archer1;
    Archer archer2;
    Archer archer3;
    Camera _camera;
    Vector2 origin;

	void Start () {
        archer1 = GameObject.Find("Archer1").GetComponent<Archer>();
        archer2 = GameObject.Find("Archer2").GetComponent<Archer>();
        archer3 = GameObject.Find("Archer3").GetComponent<Archer>();
        _camera = Camera.main;
        
    }
	
	// Update is called once per frame
	void Update () {
		
        if(Input.GetMouseButtonDown(0))
        {
            GetTarget();
            
        }

	}

    void GetTarget()
    {
        origin = _camera.ScreenToWorldPoint(Input.mousePosition);
        RaycastHit2D hit = Physics2D.Raycast(origin, Input.mousePosition);
        if (hit)
        {
            
            Enemy enemy = hit.collider.gameObject.GetComponent<Enemy>();
            if (enemy)
            {
                archer1.Shoot(enemy);
                archer2.Shoot(enemy);
                archer3.Shoot(enemy);
            }
        }
    }
    
}
