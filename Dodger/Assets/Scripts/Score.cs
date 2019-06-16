using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Score : MonoBehaviour {
    public Text scoreText;

	// Use this for initialization
	void Start () {
        InvokeRepeating("UpdateScore", 0f, 0.25f);
    }
	
	private void UpdateScore()
    {
        scoreText.text = (int.Parse(scoreText.text) + 1).ToString(); 
    }
}
