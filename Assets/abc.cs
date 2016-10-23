using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class abc : MonoBehaviour
{
	public Image GameOverImage;
	public Button Restart;
	GameObject Player;

	/*void Start()
	{
		Player = GameObject.FindWithTag ("Player");
		
	}*/

	void Update ()
	{
		Player = GameObject.FindWithTag ("Player");

		if (Time.timeScale == 0.0f)
		{
			Restart.GetComponent<Button> ().image.enabled = true;
			GameOverImage.enabled = true;
		}
		if (Player.gameObject.transform.position.y == 0.0f)
		{
			Restart.GetComponent<Button> ().image.enabled = false;
			GameOverImage.enabled = false;
			Time.timeScale = 1.0f;
		}

	}
}
