using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerBeer : MonoBehaviour
{
  	public GameObject theText;
	public GameObject timer;
	public GameObject drunk;
	public GameObject player;
	public GameObject cama;
	public GameObject camb;

	public GameObject high;

	public GameObject Beer;

	public GameObject cross;

	void OnTriggerEnter2D(Collider2D other){
	
	if(!high.activeSelf){

		drunk.SetActive(true);
		player.SetActive(false);

		cama.SetActive(false);
		camb.SetActive(true);

		theText.SetActive(true);
		timer.SetActive(true);

		Beer.SetActive(false);

	}

	if(high.activeSelf){

		high.SetActive(false);
		drunk.SetActive(false);
		cross.SetActive(true);
		theText.SetActive(false);

	}
	


	}

}
