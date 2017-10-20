using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour {

    public GameObject go;
    public int count = 0;

	// Use this for initialization
	void Start () {
        count = 0;
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButton(0))
        {
            Instantiate(go);
            checkScript(go);
            count++;
        }
	}
    void checkScript(GameObject g)
    {
        if (g.GetComponent<move>() == null)
        {
            Debug.Log("null");
            g.AddComponent<move>();
        }
    }
}
