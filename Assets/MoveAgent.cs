using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveAgent : MonoBehaviour {

	public GameObject _destination;
	// Use this for initialization
	void Start () {
		NavMeshAgent agent = GetComponent<NavMeshAgent>();
		agent.destination = _destination.transform.position; 	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
