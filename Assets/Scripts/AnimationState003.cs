using UnityEngine;
using System.Collections;

public class AnimationState003 : MonoBehaviour {

	public Animator Bean001;

	bool Jump = false;



	void Update () {
	

		if(Input.GetKey(KeyCode.Space))
		{
			Jump = true;
			Bean001.SetBool("Jump", Jump);
		}
		else if(Input.GetKeyUp(KeyCode.Space))
		{
			Jump = false;
			Bean001.SetBool("Jump", Jump);
		}



	}
}
