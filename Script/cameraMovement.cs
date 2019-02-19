using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraMovement : MonoBehaviour
{

	[SerializeField] private GameObject car;
	[SerializeField] public float speed = 2.0f;
	private float interpolation;
	private float posOffset;
	private Vector3 position;
	
	// Use this for initialization
	void Start () {
		
	}
	

	private void Update()
	{
		interpolation = speed * Time.deltaTime;
		posOffset = car.transform.position.y + 3;
        
		position = transform.position;
		position.y = Mathf.Lerp(transform.position.y, posOffset, interpolation);
        
		transform.position = position;
	}
}
