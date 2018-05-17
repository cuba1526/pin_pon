using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ball_script : MonoBehaviour {

public float speed_x;
public float speed_y;

public Text console;
	// Use this for initialization
	void Start () {
		speed_x=Random.Range(0.1f,0.2f);
		speed_y=Random.Range(0.1f,0.2f);
	}
	
	// Update is called once per frame
	void Update () {
		gameObject.transform.position += new Vector3 (speed_x, speed_y, 0f);
	}
	void OnTriggerEnter(Collider hit)
	{
		if(hit.tag=="Wall")
		{
			speed_y=-speed_y;
		}
		if(hit.tag=="Wall_left")
		{
			speed_x=0;
			speed_y=0;
			console.text="Right player win";
		}
		if(hit.tag=="Wall_right")
		{
			speed_x=0;
			speed_y=0;
			console.text="Left player win";
		}
		if(hit.tag=="Player")
		{
			speed_x=-speed_x;
		}
	}
	
}
