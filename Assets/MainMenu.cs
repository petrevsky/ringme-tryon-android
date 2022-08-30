using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    // Start is called before the first frame update
    public void showRings()
    {
        SceneManager.LoadScene("SwipeMenuScene");
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }

    public void downloadTarget()
    {
        Application.OpenURL("https://drive.google.com/file/d/1LRQ6EWUs0Zx32UDGyVBbC-CCi2CS245u/view?usp=sharing");
    }

    public void help()
    {
        SceneManager.LoadScene("HelpScene");
    }
}
