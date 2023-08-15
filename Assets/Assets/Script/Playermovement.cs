using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Playermovement : MonoBehaviour
{
    public GameObject bullet;

    public GameObject gameOver;
    public GameObject killbyz;
    public GameObject killbyb;
    public GameObject killbyr;
    public GameObject totals;

    private bool isDead;


    public bool moving = false;
    float speed = 3.0f;

    public int heal = 8;

    // Start is called before the first frame update
    void Start()
    {
        Initialize();
    }

    // Update is called once per frame
    void Update()
    {
        movement();
        GameStartt();
    }

    void movement()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.up * speed * Time.deltaTime, Space.World);
            moving = true;
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.down * speed * Time.deltaTime, Space.World);
            moving = true;
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime, Space.World);
            moving = true;
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime, Space.World);
            moving = true;
        }
        if (Input.GetKey(KeyCode.D) != true && Input.GetKey(KeyCode.A) != true && Input.GetKey(KeyCode.S) != true && Input.GetKey(KeyCode.W) != true)
        {
            moving = false;
        }
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
                Score.timeLeft = 91;
            }
            if (Input.GetKeyDown(KeyCode.Escape))
            {
                Application.Quit();
            }
        }
    }


    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Zombie01"))
        {
            heal = heal - 1;
            Destroy(GameObject.Find("Lifebar").transform.GetChild(0).gameObject);
            if (heal < 1)
            {
                Time.timeScale = 0;
                gameOver.SetActive(true);
                killbyz.SetActive(true);
                totals.gameObject.GetComponent<Text>().text = ("Score : " + (int)Score.score);
                totals.SetActive(true);
                isDead = true;


            }
        }
        if (other.gameObject.CompareTag("Boss"))
        {
            heal = heal - 3;
            Destroy(GameObject.Find("Lifebar").transform.GetChild(0).gameObject);
            if (heal < 1)
            {
                Time.timeScale = 0;
                gameOver.SetActive(true);
                killbyb.SetActive(true);
                totals.gameObject.GetComponent<Text>().text = ("Score : " + (int)Score.score);
                totals.SetActive(true);
                isDead = true;

            }
        }
        if (other.gameObject.CompareTag("Rock1"))
        {
            heal = heal - 1;
            Destroy(GameObject.Find("Lifebar").transform.GetChild(0).gameObject);
            if (heal < 1)
            {
                Time.timeScale = 0;
                gameOver.SetActive(true);
                killbyr.SetActive(true);
                totals.gameObject.GetComponent<Text>().text = ("Score : " + (int)Score.score);
                totals.SetActive(true);
                isDead = true;

            }
        }
        if (other.gameObject.CompareTag("Rockdead"))
        {
            Time.timeScale = 0;
            gameOver.SetActive(true);
            killbyr.SetActive(true);
            totals.gameObject.GetComponent<Text>().text = ("Score : " + (int)Score.score);
            totals.SetActive(true);
            isDead = true;

        }

     





    }
}
