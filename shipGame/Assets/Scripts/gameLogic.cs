using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameLogic : MonoBehaviour {

	public Text  fpHpLbl, spHpLbl;
	public GameObject fShipImage, sShipImage;
	

	public int fpHealth, spHealth;
	public bool strokeNumber;
	int attackPower = 10;
	int repareValue = 10;
	//bool fpAlive, spAlive;

	void Start () {
		fpHealth = 100;
		//fpAlive = true;
		fpHpLbl.text = "Здоровье: " + fpHealth;

		spHealth = 100;
		//spAlive = true;
		spHpLbl.text = "Здоровье: " + spHealth;

		strokeNumber = true;					//true = первый игрок
		//pColor.color = new Color(167,248,255);
		imageScale();
	}

	void Update () 
	{
		
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
				imageScale();
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
				imageScale();
				//pColor.color = new Color(167,248,255);
			}
		}
	}
	public void repareBtn()
	{
		if(strokeNumber)
		{
			fpHealth += repareValue;
			fpHpLbl.text = "Здоровье: " + fpHealth;
			strokeNumber = false;
			imageScale();
		}
		else
		{
			spHealth += repareValue;
			spHpLbl.text = "Здоровье: " + spHealth;
			strokeNumber = true;
			imageScale();
		}
	}
	void imageScale()
	{		
		fShipImage.transform.localScale = new Vector2 (fpHealth*0.01f, fpHealth*0.01f);
		sShipImage.transform.localScale = new Vector2 (spHealth*0.01f, spHealth*0.01f);
	}
	void deathScreen()
	{

	}
}
