using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BossScriptFix : MonoBehaviour
{
    public int boss = 14;

    public GameObject wintext;
    public GameObject Prass;
    public GameObject totals;

    private bool isWinner;
    // Start is called before the first frame update
    void Start()
    {
        Initialize();
    }

    // Update is called once per frame
    void Update()
    {
        if (boss <= 0)
        {
            Destroy(gameObject);
            Score.score += 50;
            wintext.SetActive(true);
            Prass.SetActive(true);
            totals.gameObject.GetComponent<Text>().text = ("Score : " + (int)Score.score);
            totals.SetActive(true);
            isWinner = true;
        }
        GameStartt();
    }

    private void Initialize()
    {
        isWinner = false;
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            boss = boss - 1;
            Destroy(GameObject.Find("LifeBoss").transform.GetChild(0).gameObject);
        }
    }

    private void GameStartt()
    {
        if (isWinner)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene(1);
                Time.timeScale = 1;
                Score.score = 0;
                Score.timeLeft = 91;
            }
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Application.Quit();
            }
        }
    }
}
