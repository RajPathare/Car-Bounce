/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
	[SerializeField] private bool isGameOver;
	[SerializeField] private GameObject gameOverScreen;
	[SerializeField] private GameObject InstructionScreen;

	// Use this for initialization
	void Start ()
	{
		if (!PlayerPrefs.HasKey("first"))
		{
			InstructionScreen.SetActive(true);
			PlayerPrefs.SetInt("first",1);
		}
	}
	
	// Update is called once per frame
	void Update () {
		if( isGameOver )
		{
			platformBehaviour.topPlatform = 12.5f;
			gameOverScreen.SetActive(true);
			/*if (Input.GetKey("space") || Input.touchCount > 0)
			{
				SceneManager.LoadScene("menu");
				isGameOver = false;
				platformBehaviour.topPlatform = 12.5f;
				//Debug.Log("GAME Running!!!!!!");
			}*/
/*}
}

public void GameOver()
{
//Debug.Log("GAME over!!!!!!");
isGameOver = true;
}
}*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    [SerializeField] public static bool isGameOver;

    [SerializeField] private GameObject gameOverScreen;
    [SerializeField] private GameObject gameOverScreen2;
    [SerializeField] private GameObject InstructionScreen;



    // Use this for initialization
    void Start()
    {
        if (!PlayerPrefs.HasKey("first"))
        {
            InstructionScreen.SetActive(true);
            PlayerPrefs.SetInt("first", 1);
        }
    }

    // Update is called once per frame


    public void continueGame()
    {

        gameOverScreen.SetActive(false);
        Debug.Log("kk");
    }

    public void GameOver()
    {
        //Debug.Log("GAME over!!!!!!");
        isGameOver = true;
    }


    public void Continue()
    {

        gameOverScreen.SetActive(true);
        


    }

    /*public void Continue2()
    {
        gameOverScreen.SetActive(true);
        isGameOver1 = false;

    }*/

    public void Continue3()
    {

        gameOverScreen2.SetActive(true);
        isGameOver = true;


    }

}

