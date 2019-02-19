/*using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class carMovement : objMovement {
	
	[SerializeField] private float jumpPower = 6.288f;
	[SerializeField] private float jumpAirPower = 0.5f;
	[SerializeField] private float gravityVal = -20.3f;
	[SerializeField] private bool isGrounded;
	[SerializeField] public static bool isGameOver;
	[SerializeField] private static int coinCount;
	[SerializeField] private static int score;
	[SerializeField] private static int highScore;
	[SerializeField] private AudioClip coinCollect;
	[SerializeField] private AudioClip jumpSound;
	[SerializeField] private GameObject HighScoreBoard;
	
	
	/*[SerializeField] public float fallMultiplier = 2.5f;
	[SerializeField] public float lowJumpMultiplier = 2f;*/

/*AudioSource audioSource;
private SpriteRenderer _spriteRenderer;

public Sprite []carSpriteList;
public GameManager gameManager;

private bool highCel = false;
float countd = 3f;



void Start ()
{
    score = 0;
    isGameOver = false;
    Physics2D.gravity = new Vector2(Physics2D.gravity.x,gravityVal);
    rb = GetComponent<Rigidbody2D>();
    audioSource = GetComponent<AudioSource>();
    speed = 3.5f;
    direction = 1;
    coinCount = PlayerPrefs.GetInt("coinCount");
    highScore = PlayerPrefs.GetInt("highScore");
    _spriteRenderer = GetComponent<SpriteRenderer>();

    _spriteRenderer.sprite = carSpriteList[PlayerPrefs.GetInt("skinId")];


    Destroy(GetComponent<PolygonCollider2D>());
    gameObject.AddComponent<PolygonCollider2D>();

    rb.velocity = new Vector2(speed * direction, rb.velocity.y);//Added
}

private void Update()
{
    if (highCel && countd >0)
    {
        countd -= Time.deltaTime;
    }

    if (countd <= 0)
    {
        HighScoreBoard.SetActive(false);

    }
}


private void FixedUpdate()
{
    DirectionChange();
    if ((Input.GetKey("space") || Input.touchCount > 0) && !isGameOver)
    {
        Jump();
    }

    //EXPERIMENTAL
    if (rb.velocity.y < 0f)
    {
        rb.AddForce(new Vector2(0, -0.4f), ForceMode2D.Impulse);
    }
    //Debug.Log(rb.velocity);

}

private void Jump()
{
    if (isGrounded && rb.velocity.y>=0f && rb.velocity.y<1f)
    {
        rb.AddForce(new Vector2(0, jumpPower), ForceMode2D.Impulse);
        audioSource.PlayOneShot(jumpSound);
    }

    if (!isGrounded && rb.velocity.y >= 4.2f)
    {
        rb.AddForce(new Vector2(0, jumpAirPower), ForceMode2D.Impulse);
    }


}

private void OnCollisionEnter2D(Collision2D other)
{
    if (other.gameObject.CompareTag("Ground"))
    {
        isGrounded = true;

        if (transform.position.y > other.gameObject.transform.position.y)
        {
            other.gameObject.GetComponent<SpriteRenderer>().color = new Color(0.831f,0.2f,0.2f);
        }
    }
    else if (other.gameObject.CompareTag("Enemy"))
    {
        isGameOver = true;
        PlayerPrefs.SetInt("coinCount",coinCount);
        gameManager.GameOver();
    }
}

private void OnTriggerEnter2D(Collider2D other)
{
    if (other.gameObject.CompareTag("Coin"))
    {	
        coinCount++;
        audioSource.PlayOneShot(coinCollect);
        PlayerPrefs.SetInt("coinCount",coinCount);
        Destroy(other.gameObject);
    }
}

private void OnCollisionStay2D(Collision2D other)
{
    if (other.gameObject.CompareTag("Ground"))
    {
        isGrounded = true;
    }
}

private void OnCollisionExit2D(Collision2D other)
{
    if (other.gameObject.CompareTag("Ground"))
    {
        isGrounded = false;
        score = (int)(transform.position.y / 2.5);
        PlayerPrefs.GetInt("highScore", highScore);
        if (highScore < score )
        {
            highScore = score;
            PlayerPrefs.SetInt("highScore",highScore);

            if (!highCel)
            {
                celebrateHigh();
                highCel = true;
            }

        }
    }
}

void celebrateHigh()
{
    HighScoreBoard.SetActive(true);
}

public int getCoinCount()
{
    return coinCount;
}
public int getScore()
{
    return score;
}
public int getHighScore()
{
    return PlayerPrefs.GetInt("highScore", highScore);;
}
}*/


using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class carMovement : objMovement
{

    //[SerializeField] private float jumpPower = 6.288f;
    [SerializeField] private float jumpPower = 6.288f;

    [SerializeField] private float jumpAirPower = 0.5f;
    [SerializeField] private float gravityVal = -20.3f;
    [SerializeField] private bool isGrounded;
    [SerializeField] public static bool isGameOver;
    [SerializeField] private static int coinCount;

    [SerializeField] public static int hitCount = 0;

    [SerializeField] private static int keyCount;


    [SerializeField] private static int score;
    [SerializeField] private static int highScore;

    [SerializeField] private static int Key;


    [SerializeField] private AudioClip coinCollect;
    [SerializeField] private AudioClip jumpSound;
    [SerializeField] private GameObject HighScoreBoard;


    /*[SerializeField] public float fallMultiplier = 2.5f;
	[SerializeField] public float lowJumpMultiplier = 2f;*/

    AudioSource audioSource;
    private SpriteRenderer _spriteRenderer;

    public Sprite[] carSpriteList;
    public GameManager gameManager;

    private bool highCel = false;
    float countd = 3f;



    void Start()
    {
        score = 0;
        isGameOver = false;
        Physics2D.gravity = new Vector2(Physics2D.gravity.x, gravityVal);
        rb = GetComponent<Rigidbody2D>();
        audioSource = GetComponent<AudioSource>();
        speed = 3.5f;
        direction = 1;
        coinCount = PlayerPrefs.GetInt("coinCount");
        highScore = PlayerPrefs.GetInt("highScore");

        keyCount = PlayerPrefs.GetInt("keyCount");

        _spriteRenderer = GetComponent<SpriteRenderer>();

        _spriteRenderer.sprite = carSpriteList[PlayerPrefs.GetInt("skinId")];


        Destroy(GetComponent<PolygonCollider2D>());
        gameObject.AddComponent<PolygonCollider2D>();

        rb.velocity = new Vector2(speed * direction, rb.velocity.y);//Added
    }

   
    private void Update()
    {
        if (highCel && countd > 0)
        {
            countd -= Time.deltaTime;
        }

        if (countd <= 0)
        {
            HighScoreBoard.SetActive(false);

        }
    }


    private void FixedUpdate()
    {
        DirectionChange();
        if ((Input.GetKey("space") || Input.touchCount > 0) && !isGameOver)
        {
            Jump();
        }

        //EXPERIMENTAL
        if (rb.velocity.y < 0f)
		{
			rb.AddForce(new Vector2(0, -0.4f), ForceMode2D.Impulse);
		}
        //Debug.Log(rb.velocity);

    }

    private void Jump()
    {
        if (isGrounded && rb.velocity.y >= 0f && rb.velocity.y < 1f)
        {
            rb.AddForce(new Vector2(0, jumpPower), ForceMode2D.Impulse);
            audioSource.PlayOneShot(jumpSound);
        }


        /* if (!isGrounded && rb.velocity.y >= 4.2f)
         {
             rb.AddForce(new Vector2(0, jumpAirPower), ForceMode2D.Impulse);
         }*/

        if (!isGrounded && rb.velocity.y >= 4.2f && rb.velocity.y<=6.5f)
        {
            rb.AddForce(new Vector2(0, jumpAirPower), ForceMode2D.Impulse);
        }


    }

    public void hitt() {

        hitCount = 0;


    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;

            if (transform.position.y > other.gameObject.transform.position.y)
            {
                other.gameObject.GetComponent<SpriteRenderer>().color = new Color(0.831f, 0.2f, 0.2f);
            }
        }
        else if (other.gameObject.CompareTag("Enemy"))
        {
            hitCount++;
            // Debug.Log(hitCount);
            //isGameOver = true;

            //Destroy(other.gameObject));

            other.gameObject.transform.position = new Vector3(0.0f, -5.0f, 0.0f);




            PlayerPrefs.SetInt("coinCount", coinCount);

            PlayerPrefs.SetInt("keyCount", keyCount);

            //gameManager.GameOver();

            speed = 3.5f;
            if (hitCount == 1)
            {

                gameManager.Continue();
            }
            /*else if (hitCount == 2)
            {
                gameManager.Continue2();
            }*/
            else if (hitCount == 2)
            {
                hitCount = 0;
                isGameOver = true;
                gameManager.Continue3();

            }

            else if (hitCount == 3)
            {
                Debug.Log("3!");

            }


        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            coinCount++;
            // keyCount++;
            audioSource.PlayOneShot(coinCollect);
            PlayerPrefs.SetInt("coinCount", coinCount);
            Destroy(other.gameObject);
        }
    }

    private void OnCollisionStay2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            /*isGrounded = true;*/
        }
    }

    private void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
            score = (int)(transform.position.y / 2.5);
            PlayerPrefs.GetInt("highScore", highScore);
            if (highScore < score)
            {
                highScore = score;
                PlayerPrefs.SetInt("highScore", highScore);

                if (!highCel)
                {
                    celebrateHigh();
                    highCel = true;
                }

            }
        }
    }


    void celebrateHigh()
    {
        HighScoreBoard.SetActive(true);
    }

    public int getCoinCount()
    {
        return coinCount;
    }

    public int getKeyCount()
    {
        return keyCount;

    }

    public int getScore()
    {
        return score;
    }
    public int getHighScore()
    {
        return PlayerPrefs.GetInt("highScore", highScore); ;
    }
}

