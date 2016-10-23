using UnityEngine;
using System.Collections;

public class PlatformCollision : MonoBehaviour {

	GameObject Player;
	float thisYpos;

	void Start()
	{

		thisYpos = transform.position.y;
	}

	// Update is called once per frame
	void Update () {
		Player = GameObject.FindWithTag("Player");

		float PlayerYpos = Player.transform.position.y;

		if(PlayerYpos > (thisYpos+0.5f))
		{
			this.gameObject.GetComponent<BoxCollider>().enabled=true;
		}
		else if(PlayerYpos < (thisYpos-1))
		{
			this.gameObject.GetComponent<BoxCollider>().enabled=false;
		}
	}
}
/*
한번 점프 하고 나면 
다시 발판을 밟기 전까지는 점프가 불가능 하도록
allowjump가 true 가 되는 조건?
*/