using UnityEngine;
using System.Collections;

public class Platform_Break : MonoBehaviour {


	void OnTriggerEnter(Collider col)
	{
		if(col.tag == "Player")
		{
			this.gameObject.GetComponent<Rigidbody>().useGravity=true;
		}
	}
}
