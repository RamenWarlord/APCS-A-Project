using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour {

    // Use this for initialization
    public void GameStart()
    {
        SceneManager.LoadScene("Game", LoadSceneMode.Single);
    }
}
