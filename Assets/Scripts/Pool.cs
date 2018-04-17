using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pool : MonoBehaviour {

    public List<Enemy> list;
    static Pool instance;

    public int Count { get; set; }

    float f;
    int i;

    EndGameUI endGame;

    public static Pool GetInstance()
    {
        if (!instance) instance = GameObject.Find("GameController").GetComponent<Pool>();
        return instance;     
    }

	void Start () {
        endGame = GameObject.Find("Canvas2").GetComponent<EndGameUI>();
        Count = 12;
        list = new List<Enemy>();
        list.Add(Instantiate(Resources.Load<Enemy>("BatArmySword")));
        list.Add(Instantiate(Resources.Load<Enemy>("Bomber")));      
        list.Add(Instantiate(Resources.Load<Enemy>("Onager")));

        for (int i=3; i<12; i+=3)
        {
            list.Add(Instantiate(list[0]));
            list.Add(Instantiate(list[1]));
            list.Add(Instantiate(list[2]));
        }

        StartCoroutine(Next());
    }

    private void Update()
    {
        if (Count == 0) endGame.EndGame("Win!");
    }


    private IEnumerator Next()
    {
        while (i<12)
        {
           
            if (f <= 0)
            {
                list[i].gameObject.SetActive(true);
                f = 1.5F;
                i++;
            }
            yield return new WaitForEndOfFrame();
            f -= Time.deltaTime;
        }
       
    }
}
