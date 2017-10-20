using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour {

    float sp = 0.01f;
    Vector3 pos;
    float timer = 0;

	// Use this for initialization
	void Start ()
    {
        sp = Random.Range(0.1f, 2.0f);
        pos = new Vector3(Random.Range(-10, 10), Random.Range(-10, 10), Random.Range(-10, 10));
        timer = 0;
	}
	
	// Update is called once per frame
	void Update ()
    {
        timer += Time.deltaTime;
        move_move();
	}
    void move_move()
    {
        if (timer >= 1.0f) timer = 0;

        pos.x = Mathf.Sin(2.0f * timer * Mathf.PI) * 10.0f * sp;
        pos.y = Mathf.Cos(2.0f * timer * Mathf.PI) * 10.0f * sp;

        transform.position = pos;
    }
}
