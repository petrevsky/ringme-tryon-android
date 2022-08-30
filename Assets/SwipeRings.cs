using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwipeRings : MonoBehaviour
{
    // Start is called before the first frame update
    public void showRing1()
    {
        SceneManager.LoadScene("RingScene");
    }

    public void showRing2()
    {
        SceneManager.LoadScene("Ring2scene");
    }

    public void showRing3()
    {
        SceneManager.LoadScene("ring3scene");
    }

    public void goBack()
    {
        SceneManager.LoadScene("MenuScene");
    }
}
