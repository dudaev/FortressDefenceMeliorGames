using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : MonoBehaviour {

    Animator animator;
    Enemy target;

    bool isShoot { get; set; }
    bool isDamage { get; set; }
	void Start () {
        animator = GetComponent<Animator>();
	}

   
    public void Shoot(Enemy enemy)
    {
        target = enemy;
        StartCoroutine(Attack());
    }

    private IEnumerator Attack()
    {
        animator.SetBool("Shoot", true);
        animator.SetBool("Idle", false);
        while (target.state!=EnemyState.Dead)
        {
            yield return new WaitUntil(() => isDamage);
            target.GetDamage();
            isDamage = false;
            yield return new WaitUntil(() =>isShoot);
            isShoot = false;
           
        }
        animator.SetBool("Idle", true);
        animator.SetBool("Shoot", false);
    }

    public void End(string s)
    {
        isShoot = true;
    }

    public void Damage()
    {
        isDamage = true;
    }
}
