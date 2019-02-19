using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
	public Text CoinText;
	public Text ScoreText;
	public Text HighScoreText;
	public Text ScoreOver;

	public carMovement CarMovement;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		//ScoreText.text = FindObjectOfType<carMovement>().getCoinCount().ToString();
		CoinText.text = CarMovement.getCoinCount().ToString();
		ScoreText.text = CarMovement.getScore().ToString();
		
		if (gameObject.active)
		{
			HighScoreText.text = CarMovement.getHighScore().ToString();
			ScoreOver.text = CarMovement.getScore().ToString();
		}
	}
}
