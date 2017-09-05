using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class iamgeScale : MonoBehaviour {

	gameLogic gL = GetComponent<gameLogic>;

	void Start () 
	{
		this.transform.localScale = new Vector3 (1.1f,1.1f,1.1f);
	}

	void Update ()
	{
		
	}
}
