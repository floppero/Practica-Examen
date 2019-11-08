using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Esfera : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.S)){
			Debug.Log("<color=yellow><b>Has pulsado la S. Esfera (en ingles Sphere) empieza por S</b></color>");
		}
	}
}
