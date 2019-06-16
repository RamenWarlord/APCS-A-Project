using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAndLook : MonoBehaviour {
    public float lifeTime = 4f;
    public float speed;
    private Transform target;
    private Vector2 pointTowards;
    private Camera topCamera;

	// Use this for initialization
	void Start () {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        topCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        float slope = (target.position.y - this.transform.position.y) / (target.position.x - this.transform.position.x);
        if (this.transform.position.x > target.position.x) //enemy x bigger than player x
        {
            pointTowards = new Vector2(target.position.x - this.transform.position.x - 10, target.position.y + (-10 * slope));
        }
        else if (target.position.x > this.transform.position.x) //player x is bigger than x
        {
            pointTowards = new Vector2(target.position.x + 10, target.position.y + (10 * slope));
        }
        else //x = x
        {
            if (this.transform.position.y > target.position.y) //enemy y > player y
            {
                pointTowards = new Vector2(target.position.x, -(this.transform.position.y) - 10);
            }
            else //enemy y < player y
            {
                pointTowards = new Vector2(target.position.x, -(this.transform.position.y) + 10);
            }
            
        }
       // pointTowards = new Vector2(target.position.x, target.position.y);


        //increase or decrease x and y with an if function based on position x and y
	}
	
	// Update is called once per frame
	void Update () {
		if (lifeTime > 0)
        {
            lifeTime -= Time.deltaTime;
            if(lifeTime <= 0)
            {
                Delete();
            }
        }

        if (this.transform.position.x >= 10f || this.transform.position.x <= -10f)
        {
            Delete();
        }

        if(this.transform.position.y >= 10f || this.transform.position.y <= -10f)
        {
            Delete();
        }
	}

    void FixedUpdate()
    {
        // this.transform.position = Vector2.right * Time.fixedDeltaTime * speed;
        transform.position = Vector2.MoveTowards(transform.position, pointTowards, speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            Debug.Log("ni hao peng you");
            target.GetComponent<PlayerHealth>().health = target.GetComponent<PlayerHealth>().health - 1;
            topCamera.GetComponent<CameraShake>().ShakeIt();
            //include ball dying animation
            Delete();
        }
    }

    void Delete()
    {
        Destroy(this.gameObject);
    }
}
