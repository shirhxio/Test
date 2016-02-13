﻿using UnityEngine;
using System.Collections;

public class FollowPlayer : MonoBehaviour {
	public Transform target;
	public Vector3 offset;

	void Start () {
		offset = GetComponent<Transform> ().position - target.position;
	}

	void Update () {
		GetComponent<Transform> ().position = target.position + offset;
	}
}
