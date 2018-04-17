using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fort : MonoBehaviour {

    static Fort instance;
    int lives = 12;
    SpriteRenderer spriteRenderer;
    public Sprite[] sprites;
    int next = 0;
    EndGameUI endGame;
    void Start () {
        endGame = GameObject.Find("Canvas2").GetComponent<EndGameUI>();
        spriteRenderer = GetComponent<SpriteRenderer>();
	}
	
	public void GetDamage()
    {
        lives--;
        if(lives%4==0)
        {
            spriteRenderer.sprite = sprites[next];
            next++;
        }
        if (lives == 0) endGame.EndGame("Lose...");
    }

    public static Fort GetInstance()
    {
        if(instance == null)
        {
            instance = GameObject.Find("Fort").GetComponent<Fort>();
        }
        return instance;
    }
}
