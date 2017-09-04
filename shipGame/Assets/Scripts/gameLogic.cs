using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameLogic : MonoBehaviour {

	public Text  fpHpLbl, spHpLbl;
	//public Image pColor;

	public int fpHealth, spHealth;
	public bool strokeNumber;
	int attackPower = 10;
	bool fpAlive, spAlive;

	void Start () {
		fpHealth = 100;
		fpAlive = true;
		fpHpLbl.text = "Здоровье: " + fpHealth;

		spHealth = 100;
		spAlive = true;
		spHpLbl.text = "Здоровье: " + spHealth;

		strokeNumber = true;					//true = первый игрок
		//pColor.color = new Color(167,248,255);
	}

	void Update () {
		
	}

	public void attackBtn()
	{
		if (strokeNumber) 
		{
			spHealth -= attackPower;
			if (spHealth <= 0) 
			{
				deathScreen ();
				spHpLbl.text = "Здоровье: 0";
			}
			else 
			{
				spHpLbl.text = "Здоровье: " + spHealth;
				strokeNumber = false;
				//pColor.color = new Color(15,69,153);
			}

		} 
		else
		{
			fpHealth -= attackPower;
			if (spHealth <= 0) 
			{
				deathScreen ();
				spHpLbl.text = "Здоровье: 0";
			}
			else 
			{
				fpHpLbl.text = "Здоровье: " + fpHealth;
				strokeNumber = true;
				//pColor.color = new Color(167,248,255);
			}
		}
	}

	void deathScreen()
	{

	}
}
