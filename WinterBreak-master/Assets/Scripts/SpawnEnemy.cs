using UnityEngine;
using System.Collections;

public class SpawnEnemy : MonoBehaviour {

	public GameObject obj;
	public Transform[] spawnPoints;
	public GameObject floor;
	Vector3[] enemySpawn = {new Vector3 (81.0f, 0.5f, -97.0f), new Vector3 (-232.0f, 0.5f, -133.0f), new Vector3 (-212.0f, 0.5f, -193.0f),
		new Vector3 (20.0f, 0.5f, -219.0f)
	};
	float minX, maxX, minY, maxY;

	// Use this for initialization
	void Start () {
		for (int i = 0; i < enemySpawn.Length; i++) {
			Instantiate (obj, enemySpawn [i], Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

}
