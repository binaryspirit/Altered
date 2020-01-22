using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam2 : MonoBehaviour
{
	public GameObject player1;
	public float xMin = -2;
	public float xMax = 2;
	public float yMin;
	public float yMax;

    // Start is called before the first frame update
    void Start()
    {
        player1 = GameObject.FindGameObjectWithTag ("high");
    }

    // Update is called once per frame
    void LateUpdate()
    {
        float x = Mathf.Clamp (player1.transform.position.x, xMin, xMax);
        float y = Mathf.Clamp (player1.transform.position.y, yMin, yMax);
        gameObject.transform.position = new Vector3 (x, y, gameObject.transform.position.z);
    }
}
