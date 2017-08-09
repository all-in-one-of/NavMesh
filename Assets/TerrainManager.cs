using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TerrainManager : MonoBehaviour {

	public GameObject _player;
	void Awake(){
		GameObject _digitalAsset = GameObject.Find("sdellaoui_Terrain_Grid1");
		for(int i=0; i<_digitalAsset.transform.childCount; i++){
			_digitalAsset.transform.GetChild(i).gameObject.AddComponent<BoxCollider>();
			_digitalAsset.transform.GetChild(i).gameObject.AddComponent<TileManager>();
		}
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
