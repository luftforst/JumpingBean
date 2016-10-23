﻿using UnityEngine;
using System.Collections;

public class AnimationState001 : MonoBehaviour {

	public Animator Bean001;

	bool Jump = false;
	bool TransOn = false;


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

		if(52.0f > transform.position.y && transform.position.y > 50.0f)
		{
			TransOn = true;
			Bean001.SetBool("TransOn", TransOn);
		}

	}


}
