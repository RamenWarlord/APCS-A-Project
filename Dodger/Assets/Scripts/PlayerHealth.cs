using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {
    public int health = 3;
    public Sprite s1;
    public Sprite s2;
    public Sprite s3;
    public Sprite s4;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if (health == 3)
            GetComponent<SpriteRenderer>().sprite = s1;
        if (health == 2)
            GetComponent<SpriteRenderer>().sprite = s2;
        if (health == 1)
            GetComponent<SpriteRenderer>().sprite = s3;
        if (health == 0)
            GetComponent<SpriteRenderer>().sprite = s4;
    }
}
