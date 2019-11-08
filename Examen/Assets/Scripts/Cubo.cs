using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cubo : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.C)){
			Debug.Log("<color=green>Has pulsado la tecla C. Cubo empieza por C</color>");
		}
		
	}
}
