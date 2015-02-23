﻿using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {
	public Transform target;
	private float smoothing = 5f;
	private Vector3 offset;

	// Use this for initialization
	void Start () 
	{
		offset = transform.position - target.position;
	}
	
	// Update is called once per frame
	void FixedUpdate () 
	{
		Vector3 targetCamPos = target.position + offset;

		transform.position = Vector3.Lerp (transform.position, targetCamPos, smoothing * Time.deltaTime);
	}
}
