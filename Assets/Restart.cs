using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Restart : MonoBehaviour 
{

	//public Image GameOverImage;
	//public Button Restart1;

	public void restart()
	{
		Application.LoadLevel ("doodleMain");
		Time.timeScale = 1.0f;
		//StartCoroutine ("checkfalse");
	}

	/*IEnumerator checkfalse()
	{
		yield return new WaitForSeconds (1);
		Restart1.GetComponent<Button> ().image.enabled = false;
		GameOverImage.enabled = false;
	}*/
}
