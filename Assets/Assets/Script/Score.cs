using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour
{
    public Text countText;
    public Text timeLeftUI;

    public GameObject totalScore;
    public GameObject killbyt;
    public GameObject Timeout;

    private bool isDead;


    public static float timeLeft = 91;
    public static int score;

    // Start is called before the first frame update
    void Start()
    {
        Initialize();
    }

    // Update is called once per frame
    void Update()
    {
        countText.text = "Score : " + score;

        timeLeft -= Time.deltaTime;
        timeLeftUI.gameObject.GetComponent<Text>().text = ("Time : " + (int)timeLeft);
        if (timeLeft < 0.1f)
        {
            Time.timeScale = 0;
            Timeout.SetActive(true);
            killbyt.SetActive(true);
            totalScore.gameObject.GetComponent<Text>().text = ("Score : " + Score.score);
            totalScore.SetActive(true);
            isDead = true;
        }

        GameStartt();
    }

    private void Initialize()
    {
        isDead = false;
    }

    private void GameStartt()
    {
        if (isDead)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(1);
                Time.timeScale = 1;
                Score.score = 0;
                Score.timeLeft = 61;
            }
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Application.Quit();
            }
        }
    }
}
