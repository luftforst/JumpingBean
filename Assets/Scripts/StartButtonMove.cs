using UnityEngine;
using System.Collections;

public class StartButtonMove : MonoBehaviour {

	bool StartButtonClick = false;
	public GameObject title;
	
	// Update is called once per frame
	void Update () {
	
		if(StartButtonClick == false && transform.position.y < 87)
		{
			title.transform.Translate(0,-1,0);
			this.transform.Translate(0,1,0);
		}


		if(StartButtonClick == true && transform.position.y > -300)
		{
			title.transform.Translate(0,4,0);
			this.transform.Translate(0,-4,0);
		}
	}

	public void OnClick()
	{

			Debug.Log("press click");
			StartButtonClick = true;
	}
}
