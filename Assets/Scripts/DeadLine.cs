using UnityEngine;
using System.Collections;

public class DeadLine : MonoBehaviour {

	void OnTriggerEnter(Collider col)
	{
		if(col.tag == "Spawner")
		{
			Destroy(col.gameObject);
		}
	}
}
