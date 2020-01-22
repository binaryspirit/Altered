using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerWeed : MonoBehaviour
{
  
	public GameObject theText;
	public GameObject timer;
	public GameObject high;
	public GameObject player;
	public GameObject cama;
	public GameObject camb;

	void OnTriggerEnter2D(Collider2D other){
	
		high.SetActive(true);
		player.SetActive(false);

		cama.SetActive(false);
		camb.SetActive(true);

		theText.SetActive(true);
		timer.SetActive(true);

		StartCoroutine(Wait ());


	}
	IEnumerator Wait(){
		yield return new WaitForSeconds(1f);
		theText.SetActive(false);
	}
}
