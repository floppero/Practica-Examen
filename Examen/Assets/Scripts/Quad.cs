using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quad : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.Q)){
			Debug.Log("<b><i>Has pulsado la Q. Quad empieza por Q</i></b>");
		}
	}
}
