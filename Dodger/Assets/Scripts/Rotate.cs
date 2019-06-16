using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {
	public float speed;
	private Vector3 v; //public float value that can be changed in unity engine to increase speed of spinning/rotation
	// Use this for initialization
	void Start () 
	{
		v = new Vector3(0, 0, speed);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void FixedUpdate()
	{
		transform.Rotate(v * Time.deltaTime); //rotates it based on speed, deltatime is for lag issues based on comp specs, vector3.up is so that it rotates correctly basd on how it is
	}
}
