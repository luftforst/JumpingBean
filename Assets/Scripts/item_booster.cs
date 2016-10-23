using UnityEngine;
using System.Collections;

public class item_booster : MonoBehaviour {

	GameObject Player;

	void Start()
	{
		Player = GameObject.FindWithTag ("Player");
	}
	void OnTriggerEnter(Collider col)
	{
		Start ();
		if(col.tag == "Player")
		{
			Player.GetComponent<Rigidbody>().AddForce(new Vector3(0,30,0), ForceMode.VelocityChange);
			Destroy(this.gameObject);
		}
	}
}
