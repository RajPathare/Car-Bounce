using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

/*public class platformBehaviour : MonoBehaviour
{
	[SerializeField] private GameObject car;
	[SerializeField] private GameObject coin;
	[SerializeField] public static float topPlatform = 12.5f;

	/*public enemyCarMovement EnemyCar;
	

	// Use this for initialization
	/*void Start () {
		InvokeRepeating("DestroyPlatformSpawn", 3.0f, 1.0f);
	}
	
	// Update is called once per frame
	/*void Update () {//changed form fixed

		/*if (car.transform.position.y > transform.position.y && (car.transform.position - transform.position).y > 6.0f)
		{
			topPlatform += 2.5f;
			transform.position = new  Vector3(transform.position.x, topPlatform, transform.position.z);
			//call emenycar spawn
			//FindObjectOfType<enemyCarMovement>().SpawnCar(topPlatform);
			EnemyCar.SpawnCar(topPlatform);
			
			float spawnChance = Random.value;
			if (spawnChance <= 0.25f)
			{
				float randX = Random.Range(-1.80f, 1.8f);
				Vector3 newPos = new Vector3(randX, topPlatform + 0.5f, transform.position.z);
				Instantiate(coin, newPos, Quaternion.identity);
			}
		}	*/
		
	

	/*private void DestroyPlatformSpawn()
	{
		if (car.transform.position.y > transform.position.y && (car.transform.position - transform.position).y > 6.0f)
		{
			topPlatform += 2.5f;
			transform.position = new  Vector3(transform.position.x, topPlatform, transform.position.z);
			gameObject.GetComponent<SpriteRenderer>().color = new Color(0.20f,0.20f,0.20f);
			//call emenycar spawn
			//FindObjectOfType<enemyCarMovement>().SpawnCar(topPlatform);
			EnemyCar.SpawnCar(topPlatform);
			
			float spawnChance = Random.value;
			if (spawnChance <= 0.35f)
			{
				float randX = Random.Range(-1.80f, 1.8f);
				Vector3 newPos = new Vector3(randX, topPlatform + 0.5f, transform.position.z);
				Instantiate(coin, newPos, Quaternion.identity);
			}
		}
	}
	
}
*/