using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MineRock : MonoBehaviour {
    public GameObject panel;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnMouseOver()
    {

        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("chur");
        }
    }
}
