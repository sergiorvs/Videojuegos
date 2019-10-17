using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public GameObject food;
    private GameObject pacman;
    float time;
    // Start is called before the first frame update
    void Start()
    {
        pacman = GameObject.Find("pacman");
        time = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {
        if(food.transform.childCount == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        if(pacman == null && time > 3.5f)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else
        {
            time += Time.deltaTime;
        }
    }
}
