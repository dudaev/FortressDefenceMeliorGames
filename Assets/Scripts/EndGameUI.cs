using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EndGameUI : MonoBehaviour {

    Text result;
    GameObject panel;

    private void Start()
    {
        panel = GameObject.Find("EndGamePanel");
        result = GameObject.Find("Result").GetComponent<Text>();
        panel.SetActive(false);
    }

    public void EndGame(string res)
    {
        panel.SetActive(true);
        result.text = res;
		if(res!="Win!")
        Time.timeScale = 0;
    }

    public void Restart()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }

    public void Menu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

}
