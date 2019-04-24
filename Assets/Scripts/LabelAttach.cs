using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LabelAttach : MonoBehaviour {

    // Use this for initialization
    public Transform target;
    public Camera cam;
    public Vector3 offset = Vector3.up;
    void Start () {
      
    }
	
	// Update is called once per frame
	void Update () {
		 transform.position = cam.WorldToViewportPoint(target.position + offset);
	}
}
