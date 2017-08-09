using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileManager : MonoBehaviour {
	GameObject _player;
	Vector3 _center;
	void OnMouseDown()
	{
		Debug.Log(transform.position);
		_player.transform.position = _center;
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void Awake(){
		_center = GetComponent<BoxCollider>().center;
		_center.y += 0.25f;
		_player = GameObject.Find("Terrain").GetComponent<TerrainManager>()._player;
	}
}
