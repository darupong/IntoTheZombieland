using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonScript2 : MonoBehaviour
{
    public void selectScene()
    {
        switch (this.gameObject.name)
        {
            case "StartB":
                SceneManager.LoadScene(1);
                break;
            case "StartC":
                SceneManager.LoadScene(1);
                break;
            case "HTP":
                SceneManager.LoadScene(6);
                break;
            case "Page2":
                SceneManager.LoadScene(7);
                break;
            case "Menu":
                SceneManager.LoadScene(0);
                break;
            case "Credit":
                SceneManager.LoadScene(8);
                break;
            case "Menu2":
                SceneManager.LoadScene(0);
                break;
            case "Exit":
                Application.Quit();
                break;
        }
    }
}
