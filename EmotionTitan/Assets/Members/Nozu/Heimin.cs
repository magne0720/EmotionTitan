using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heimin : MonoBehaviour {

    [SerializeField]
    BaseCharacter Control;


    // Use this for initialization
    void Start () {
        Control = GetComponent<BaseCharacter>();
        Control.MySpeed = 4.0f;
   	}
	
	// Update is called once per frame
	void Update () {

        Control.TargetPosition = Control.MyPosition;
        if (Input.GetKey(KeyCode.W))
        {
            Control.MoveFront();
        }
       else if (Input.GetKey(KeyCode.S))
        {
            Control.MoveBack();
        }
        if (Input.GetKey(KeyCode.A))
        {
            Control.MoveLeft();
        }
        else if (Input.GetKey(KeyCode.D))
        {
            Control.MoveRight();
        }
    }
}
