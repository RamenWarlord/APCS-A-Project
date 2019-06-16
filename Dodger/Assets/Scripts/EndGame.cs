using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour {
    public GameObject gameOverMenu;
    public GameObject player;

    // Update is called once per frame
    void Update()
    {
        if (player.GetComponent<PlayerHealth>().health == 0)
            GameOver();
        else
        {
            gameOverMenu.SetActive(false);
            Time.timeScale = 1f;
        }
    }

    void GameOver()
    {
        
        Time.timeScale = 0f;
        gameOverMenu.SetActive(true);
    }
}
