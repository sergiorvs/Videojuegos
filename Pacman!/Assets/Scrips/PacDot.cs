using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacDot : MonoBehaviour
{
    private GameObject score;
    private int scr;

    private void Start()
    {
        score = GameObject.Find("scr");
    }
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.name == "pacman")
        {
            Destroy(gameObject);
            FindObjectOfType<AudioManager>().Play("wakawaka");
            scr = int.Parse(score.GetComponent<TextMesh>().text) + 10;
            score.GetComponent<TextMesh>().text = scr.ToString();
        }
    }
}
