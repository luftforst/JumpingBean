using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class fall : MonoBehaviour
{
	GameObject Player;

	
	void Update ()
	{
		Player = GameObject.FindWithTag ("Player");

		if( this.transform.position.y > Player.transform.position.y + 50.0f )
		{
			Time.timeScale = 0.0f;
			//Destroy(Player.gameObject);
		}
	}
}