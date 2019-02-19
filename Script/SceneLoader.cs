using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneLoader : MonoBehaviour
{
    [SerializeField] private GameObject instructionScreen;
    [SerializeField] private Toggle sound;


    private void Start()
    {
        
            if (PlayerPrefs.GetInt("sound") == 0)
            {
                if (SceneManager.GetActiveScene().name == "menu")
                    sound.isOn = true;
                AudioListener.pause = true;
            }
            if (PlayerPrefs.GetInt("sound") == 1)
            {
                if (SceneManager.GetActiveScene().name == "menu")
                    sound.isOn = false;
                AudioListener.pause = false;
            }
        
    }

    public void startGame()
    {

        SceneManager.LoadScene("main");
        if (PlayerPrefs.GetInt("sound") == 0)
        {
            if (SceneManager.GetActiveScene().name == "menu")
                sound.isOn = true;
            AudioListener.pause = true;
        }
        if (PlayerPrefs.GetInt("sound") == 1)
        {
            if (SceneManager.GetActiveScene().name == "menu")
                sound.isOn = false;
            AudioListener.pause = false;
        }

    }

    public void menu()
    {
        SceneManager.LoadScene("menu");
        if (PlayerPrefs.GetInt("sound") == 0)
        {
            if (SceneManager.GetActiveScene().name == "menu")
                sound.isOn = true;
            AudioListener.pause = true;
        }
        if (PlayerPrefs.GetInt("sound") == 1)
        {
            if (SceneManager.GetActiveScene().name == "menu")
                sound.isOn = false;
            AudioListener.pause = false;
        }

    }


    public void quitGame()
    {
        Application.Quit();
    }
    
    public void soundControl(bool isActive)
    {
        AudioListener.pause = isActive;

        if (AudioListener.pause)
        {
            PlayerPrefs.SetInt("sound", 0);
            Debug.Log(AudioListener.pause + " 0 ");
        }
        else
        {
            PlayerPrefs.SetInt("sound", 1);
            Debug.Log(AudioListener.pause + " 1 ");
        }

    }
}