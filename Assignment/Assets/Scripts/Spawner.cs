using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour{
	public float spawnDelay = .3f;
	//spawn delay so obstacles do not clash together

	public GameObject wick;

	public Transform[] spawnPoints;

	float nextTimeToSpawn = 0f;

	void Update ()
	{
		if (nextTimeToSpawn <= Time.time)
		{
			SpawnWick();
			nextTimeToSpawn = Time.time + spawnDelay;
		}
	}

	void SpawnWick ()
	{
		//randomized spawn range + randomized speed
		int randomIndex = Random.Range(0, spawnPoints.Length);
		Transform spawnPoint = spawnPoints[randomIndex];

		Instantiate(wick, spawnPoint.position, spawnPoint.rotation);
	}

}
