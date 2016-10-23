using UnityEngine;
using System.Collections;

public class Jump : MonoBehaviour {

	public float jumpPower = 3.0f;
	public Rigidbody rb;
	bool isjump = false;
	int allowJump = 1;
	public int allowCount;

	void Start()
	{
		rb = GetComponent<Rigidbody> ();
	}
	

	void Update()
	{
		if(Input.GetKeyDown(KeyCode.Space))
		{
			StartCoroutine("jump");
		}
		Debug.Log (allowJump);
	}
	
	IEnumerator jump()
	{
		yield return new WaitForSeconds (0.4f);
		isjump = true;

	}
	
	void FixedUpdate()
	{
		if( isjump && allowJump>0)
		{
			rb.AddForce(new Vector3(0,1*jumpPower,0), ForceMode.VelocityChange);
			rb.WakeUp();
			isjump = false;
			allowJump--;
		}
	}

	void OnCollisionEnter(Collision col)
	{
		allowJump=allowCount;
	}
}
