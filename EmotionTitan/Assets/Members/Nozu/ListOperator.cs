using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListOperator : MonoBehaviour
{

    public List<GameObject> Characters;

    // Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetMouseButtonDown(0))
        {
            packList();
        }
        if (Input.GetMouseButtonDown(1))
        {
            CharacterDeath(1);
        }
    }
    void packList()
    {

    }
    void CharacterDeath(int index)
    {
        Characters.RemoveAt(index);
    }
}
