using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Score : MonoBehaviour {

	public float score=0;
	public Text scorePrint;
	GameObject Player;

	bool TransOnOff2 = false;
	bool TransOnOff3 = false;

	public GameObject GameObject1;
	public GameObject Bean001;
	public GameObject Bean002;
	public GameObject Bean003;

	GameObject Bean002_child;
	GameObject Bean003_child;

	public GameObject TransEffect;

	void Start()
	{
		Player = GameObject.FindWithTag ("Player");

	}

	void Update () {
		Start ();

		score = Player.transform.position.y;
		scorePrint.text = score.ToString ("0.00");

		if(! TransOnOff2 )
		{
			if( 52.0f > score && score > 50.0f)
			{
				TransOnOff2 = true;
				StartCoroutine ("Trans002");
				StartCoroutine ("Effect");

			}
		}

		if(! TransOnOff3 )
		{
			if( 152.0f > score && score > 150.0f)
			{
				TransOnOff3 = true;
				StartCoroutine ("Trans003");
				StartCoroutine ("Effect");
			}
		}

	}

	IEnumerator Trans002()
	{
		yield return new WaitForSeconds(4.0f);
		Bean002_child = Instantiate(Bean002, Player.transform.position, Player.transform.rotation)as GameObject;
		Bean002_child.transform.parent = GameObject1.transform;

		Destroy (Bean001);

	}

	IEnumerator Trans003()
	{
		yield return new WaitForSeconds(3.0f);
		Bean003_child = Instantiate(Bean003, Player.transform.position, Player.transform.rotation)as GameObject;
		Bean003_child.transform.parent = GameObject1.transform;

		Destroy (Bean002_child);
	}

	IEnumerator Effect()
	{
		yield return new WaitForSeconds (2.0f);
		GameObject effect1 = Instantiate (TransEffect, Player.transform.position +new Vector3(0,0.6f,0), Player.transform.rotation)as GameObject;
		effect1.transform.parent = Player.transform;
		Destroy (effect1, 2.3f);
	}
}
