using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class enemyCarMovement : objMovement {
	
	[SerializeField] public GameObject car;
	
	// Use this for initialization
	private SpriteRenderer _spriteRenderer;
	/*public Sprite fast;
	public Sprite slow;
	public Sprite normal;*/
	public Sprite []enemyCarSpriteList;
	public float[] speedsList;
	private Queue<bool> Q1 = new Queue<bool>(new[] {true, false});
	
	private int timesNotSpawn = 0;
	private int timesSpawn = 0;
	
	void Start ()
	{
		rb = GetComponent<Rigidbody2D>();
		_spriteRenderer = GetComponent<SpriteRenderer>();
		
		int radValSprite = Random.Range(0, enemyCarSpriteList.Length);
		float radValDir = Random.value;
		
		if (radValDir < 0.5)
		{
			direction = 1;
		}
		else
		{
			direction = -1;
		}
		
		_spriteRenderer.sprite = enemyCarSpriteList[radValSprite];
		if (radValSprite == 0 || radValSprite == 1 || radValSprite == 7)
		{
			speed = speedsList[0];
		}
		else if (radValSprite == 2 || radValSprite == 4 || radValSprite == 6)
		{
			speed = speedsList[1];
		}
		else
		{
			speed = speedsList[2];
		}
		
	
		Destroy(GetComponent<PolygonCollider2D>());
		gameObject.AddComponent<PolygonCollider2D>();
		
		InvokeRepeating("DestroyEnemyCar", 5.0f, 4.0f);
		
		rb.velocity = new Vector2(speed * direction, rb.velocity.y);//Added
		
	}
	
	

	public void SpawnCar(float topPlatform)
	{
		float spawnChance = Random.value;

		if (spawnChance <= 0.70f && timesSpawn <= 1)
		{
			float randX = Random.Range(-1.80f, 1.8f);
			Vector3 newPos = new Vector3(randX, topPlatform + 0.3f, transform.position.z);
			Instantiate(gameObject, newPos, Quaternion.identity);
			timesNotSpawn = 0;
			timesSpawn++;
		}
		else
		{
			timesSpawn = 0;
			timesNotSpawn++;
		}

		if (timesNotSpawn >= 2)//allow only 1 empty
		{
			SpawnCar(topPlatform);
		}
	}

	private void Update()//changed form fixed
	{
		DirectionChange();
		/*if (car.transform.position.y > transform.position.y && (car.transform.position - transform.position).y > 6.0f)
		{
			Destroy(gameObject);
		}*/
	}

	private void DestroyEnemyCar()//moved from update
	{
		if (car.transform.position.y > transform.position.y && (car.transform.position - transform.position).y > 6.0f)
		{
			Destroy(gameObject);
		}
	}
	
}
