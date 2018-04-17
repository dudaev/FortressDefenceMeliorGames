using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    protected Vector3 target;
    protected float speed;

    Animator animator;

    public EnemyState state { get; set; }
    protected int lives;

    public RedColor red;

    SpriteRenderer spriteRenderer;

   

	protected void Start () {

        state = EnemyState.Walk;
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();

       
	}
	
	
	void Update () {

        if (state == EnemyState.Walk) Walk();

	}

    public void DamageFort()
    {
        Fort.GetInstance().GetDamage();
    }

    void Walk()
    {
            transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
        if (transform.position.x >= target.x)
        {
            state = EnemyState.Attack;
            animator.SetBool("Attack", true);
        }
    }

    public void GetDamage()
    {
        lives--;

        if (lives <= 0)
        {
            animator.SetBool("Death", true);
            state = EnemyState.Dead;
        }
        else
            StartCoroutine(Fliker());
    }

    private IEnumerator Fliker()
    {
        spriteRenderer.color = red.red;
        float f = 0;
        while (f < 0.2F)
        {
            yield return new WaitForEndOfFrame();
            f += Time.deltaTime;
                }
        spriteRenderer.color = Color.white;
    }

    public void Death()
    {
        Pool.GetInstance().Count--;
        Destroy(gameObject);
    }

   
}

public enum EnemyState
{
    Walk,
    Attack,
    Dead
}
