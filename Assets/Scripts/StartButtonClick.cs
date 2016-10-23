using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class StartButtonClick : MonoBehaviour {

	public void StartButton()
	{
		if(transform.position.y > -500)
		{
			this.transform.Translate(0,-1,0);
		}
	}

	public void Update()
	{
		StartButton ();
	}
}
