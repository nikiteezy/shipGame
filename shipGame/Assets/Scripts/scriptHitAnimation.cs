using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptHitAnimation : MonoBehaviour {

	void Start () {
		
	}
	
	void Update () {
		
	}
	public void attackBtn()
	{
		GetComponent<Animator>().SetTrigger("hit");
	}
}
