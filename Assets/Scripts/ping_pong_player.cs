using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ping_pong_player : MonoBehaviour {

public GameObject player;
public GameObject player_2;
public GameObject ball;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.D) && player.transform.position.x <= -0.5) {
			player.transform.position += new Vector3 (1.0f, 0, 0);
		}
		if (Input.GetKey (KeyCode.A) && player.transform.position.x >= -9.8) {
			player.transform.position -= new Vector3 (1.0f, 0, 0);
		}
		if (Input.GetKey (KeyCode.W) && player.transform.position.y < 4) {
			player.transform.position += new Vector3 (0, 1.0f, 0);
		}
		if (Input.GetKey (KeyCode.S) && player.transform.position.y > -4) {
			player.transform.position -= new Vector3 (0, 1.0f, 0);
		}
		if (Input.GetKey (KeyCode.RightArrow) && player_2.transform.position.x <= 9.8) {
			player_2.transform.position += new Vector3 (1.0f, 0, 0);
		}
		if (Input.GetKey (KeyCode.LeftArrow) && player_2.transform.position.x >= 0.5) {
			player_2.transform.position -= new Vector3 (1.0f, 0, 0);
		}
		if (Input.GetKey (KeyCode.UpArrow) && player_2.transform.position.y < 4) {
			player_2.transform.position += new Vector3 (0, 1.0f, 0);
		}
		if (Input.GetKey (KeyCode.DownArrow) && player_2.transform.position.y > -4) {
			player_2.transform.position -= new Vector3 (0, 1.0f, 0);
		}
		if(Input.GetKey(KeyCode.R))
		{
			restart();
		}
	}

	void restart()
	{
		ball.transform.position=new Vector3(0,0,0);
		ball.GetComponent<ball_script>().speed_x=Random.Range(0.1f,0.2f);
		ball.GetComponent<ball_script>().speed_y=Random.Range(0.1f,0.2f);
		ball.GetComponent<ball_script>().console.text="";
	}
}
