using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBehaviour : MonoBehaviour {
	
	[SerializeField] private GameObject car;
	[SerializeField] private GameObject coin;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	private void FixedUpdate()
	{
		/*if (car.transform.position.y > transform.position.y && (car.transform.position - transform.position).y > 6.0f)
		{
			//Destroy(gameObject);
			gameObject.SetActive(false);
		}*/
	}
	
	/*public void SpawnCoin(float topPlatform)
	{
		float spawnChance = Random.value;

		if (spawnChance <= 0.25f)
		{
			float randX = Random.Range(-1.80f, 1.8f);
			Vector3 newPos = new Vector3(randX, topPlatform + 0.5f, transform.position.z);
			GameObject newCoin = Instantiate(gameObject, newPos, Quaternion.identity);
			
		}
	}*/
	
}
