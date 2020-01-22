using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TracerFX : MonoBehaviour
{
    public float timeBtwSpawns;
    public float startTimeBtwSpawns;

    public GameObject echo;
    private Player_Move_Prot player;

    void Start(){
    	player = GetComponent<Player_Move_Prot>();
    }

    void Update(){

    	if(player.moveX != 0){

    		if(timeBtwSpawns <= 0){
    		GameObject instance = (GameObject)Instantiate(echo, transform.position, Quaternion.identity);
    		Destroy(instance, 0.9f);
    		timeBtwSpawns = startTimeBtwSpawns;
    	} else {
    		timeBtwSpawns -= Time.deltaTime;
    	}

    	}

    	

    }
}
