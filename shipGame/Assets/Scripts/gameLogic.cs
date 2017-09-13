using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameLogic : MonoBehaviour {

	public Text  fpHpLbl, spHpLbl;
	public GameObject fShipImage, sShipImage;

	public int fpHealth, spHealth;
	public bool strokeNumber;
	int repareValue = 5;

	Vector3 firstCPosition = new Vector3(-500,-225,0);
	Vector3 secondCPosition = new Vector3(-300,-225,0);
	Vector3 thirdCPosition = new Vector3(-100,-225,0);
	Vector3 fourthCPosition = new Vector3(100,-225,0);
	Vector3 fifthCPosition = new Vector3(300,-225,0);
	Vector3 sixthCPosition = new Vector3(500,-225,0);

	public GameObject firstCardBtn;
	public GameObject secondCardBtn;
	public GameObject thirdCardBtn;
	public GameObject fourthCardBtn;
	public GameObject fifthCardBtn;
	public GameObject sixthCardBtn;


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

		startSetActiveFalse();
		//testMeth ();
	}
	void Update () 
	{	
	}
	void startSetActiveFalse()
	{
		firstCardBtn.SetActive(false);
		secondCardBtn.SetActive(false);
		thirdCardBtn.SetActive(false);
		fourthCardBtn.SetActive(false);
		fifthCardBtn.SetActive(false);
		sixthCardBtn.SetActive(false);
	}
	public void startCardPosition(Vector3 position)//получает вектор, на его место ставит карту из списка
	{
		int volume = Random.Range(0,2);
		switch (volume)
		{
			case 0: //fifthCardBtn.transform.Translate(fifthCPosition);
			//firstCardBtn.transform.Translate(firstCardPosition);
			break;
			case 1: break;
			case 2: break;
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
	public void imageScale()
	{		
		fShipImage.transform.localScale = new Vector2 (fpHealth*0.01f, fpHealth*0.01f);
		sShipImage.transform.localScale = new Vector2 (spHealth*0.01f, spHealth*0.01f);
	}
	public void attackLogic(int attackPower)//скрипт для нанесения урона
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
	public void normalAttackBtn()//обычная атака
	{
		attackLogic(5);
	}
	public void buckshotAttackBtn()//картечь
	{
		attackLogic(15);
	}
	public void chainAttackBtn()//ядра с цепями
	{
		attackLogic(10);
	}
	public void musketsAttackBtn()//мушкеты
	{
		attackLogic(1);
	}
	public void boardingAttackBtn()//абордаж
	{
		attackLogic(50);
	}
	public void cardsPositions()
	{

	}
	public void deathScreen()
	{
	}
	public void testMeth()
	{
		firstCardBtn.SetActive (true);
		firstCardBtn.transform.localPosition = firstCPosition;
	}
	
}