
using UnityEngine;
using System.Collections;

public class UnityChanControlScriptWithRgidBody : MonoBehaviour
{
	public bool useCurves = true;				
												
	public float useCurvesHeight = 0.5f;		


	public float rotateSpeed = 5.0f;
	private Vector3 velocity;
	private GameObject cameraObject;
	private GameObject Player;


	void Start ()
	{

	}
	

	void FixedUpdate ()
	{
		float h = Input.GetAxis("Horizontal");				
		transform.Rotate(0, h * -rotateSpeed, 0);	
		cameraObject = GameObject.FindWithTag("MainCamera");
		Player = GameObject.FindWithTag("Player");
	}

}
