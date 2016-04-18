using UnityEngine;
using System.Collections;

public class SpawnItems : MonoBehaviour {
	//some placeholder vector3s for now, we can change it once we have the map
	Vector3[] itemSpawnPoints = {new Vector3 (43.0f, 0.5f, -90.0f), new Vector3 (91.0f, 0.5f, -119.0f), new Vector3 (-152.0f, 0.5f, -144.0f),
		new Vector3 (-184.0f, 0.5f, -178.0f), new Vector3 (-243.0f, 0.5f, -177.0f), new Vector3 (-243.0f, 0.5f, -134.0f),
		new Vector3 (-241.0f, 0.5f, 92.0f), new Vector3 (5.0f, 0.5f, 160.0f), new Vector3 (40.0f, 0.5f, 191.0f), 
		new Vector3 (124.0f, 0.5f, 210.0f), new Vector3(-12.5f, 0.5f, 2.5f)};
	bool[] item = { false, false, false, false, false, false, false, false, false, false, false };

	//we can put the gameobjects in once we import them into the game
	public GameObject obj;
	//public GameObject[] powerUps = {obj};

	public float timeToSpawn = 0f;
	public float spawnTime = 10f;
	public int numOfPowerups = 0;

	void Start () {
		//spawn the first set of power ups, can add more if we decide we want more powerups at the start
		Instantiate (obj, itemSpawnPoints [10], Quaternion.identity);
		item [10] = true;
	}



	// Update is called once per frame

	void Update () {

		if (Time.time > timeToSpawn) {//&& slots not all full

			timeToSpawn = Time.time + spawnTime;
			//only spawn at unused points
			int val = allTrue();
			if (val != -1) {
				Instantiate (obj, itemSpawnPoints [val], Quaternion.identity);
				item [val] = true;
			}

		}

		//TO ADD: check if there is already a powerup at that spawn location before spawning a new one
	}

	int allTrue(){
		int counter = 0;
		while (counter < 5) {
			int i = Random.Range (0, item.Length);
			if (item [i] == false)
				return i;
			else
				counter++;
		}
		return -1;
	}

	public void powerupGone(Vector3 pos){
		for (int i = 0; i < itemSpawnPoints.Length; i++) {
			if(pos.Equals(itemSpawnPoints[i])){
				item[i] = false;
				break;
			}
		}
	}
}
