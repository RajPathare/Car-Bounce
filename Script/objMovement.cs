using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objMovement : MonoBehaviour {
	
	protected Rigidbody2D rb;
	protected float speed = 4f;
	[SerializeField] protected int direction = 1;
	[SerializeField] private bool facingRight = true;

	// Use this for initialization
	void Start ()
	{

	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	protected void DirectionChange()
	{
		if (carMovement.isGameOver == false)
		{
			/*rb.velocity = new Vector2(speed * direction, rb.velocity.y);*/
			if (rb.transform.localPosition.x >= 2.02)
			{
				direction = -1;
			}
			else if (rb.transform.localPosition.x <= -1.97)
			{
				direction = 1;
			}

			if (direction == -1 && facingRight)
			{
				FlipSprite();
				facingRight = !facingRight;
				rb.velocity = new Vector2(speed * direction, rb.velocity.y);//Added
			}
			else if (direction == 1 && !facingRight)
			{
				FlipSprite();
				facingRight = !facingRight;
				rb.velocity = new Vector2(speed * direction, rb.velocity.y);//Added
			}
		}
		else
		{
			rb.velocity = new Vector2(0, rb.velocity.y);
		}
	}

	private void FlipSprite(){
		transform.localScale = new Vector3(transform.localScale.x*-1,transform.localScale.y,transform.localScale.z);
	}

}
