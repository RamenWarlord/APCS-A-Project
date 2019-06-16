using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class EnemySpawning : MonoBehaviour {

    public GameObject enemy;
    public float speed;
    public float spawnRate;
    private float randomX;
    private float randomY;
    Vector2 spawnSpot;
    float nextSpawn = 0.0f;
    public Text score;
    public float startTime;
	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        if (int.Parse(score.text) > startTime)
        {
            if (Time.time > nextSpawn)
            {
                nextSpawn = Time.time + spawnRate;
                //     randomX = Random.value > 0.5f ? Random.Range(3.5f, 4) : Random.Range(-3.5f, -4);//note to self: change values so it doesnt just spawn at the corners
                //     randomY = Random.value > 0.5f ? Random.Range(3.5f, 4) : Random.Range(-3.5f, -4);
                randomX = Random.value > 0.5f ? Random.Range(0, 7f) : Random.Range(-7f, 0);//note to self: change values so it doesnt just spawn at the corners
                if (randomX > -5 && randomX < 5) //x value is within the circle
                {
                    randomY = Random.value > 0.5f ? 5 : -5;//y value will be outside the circle
                }
                else //x value is outside the circle
                {
                    randomY = Random.value > 0.5f ? Random.Range(0, 3f) : Random.Range(-3f, 0);//y value will be inside the circle 
                }
                spawnSpot = new Vector2(randomX, randomY);
                Instantiate(enemy, spawnSpot, Quaternion.identity);
            }
        }
    
    }
}
