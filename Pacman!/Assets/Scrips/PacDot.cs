using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacDot : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.name == "pacman")
        {
            Destroy(gameObject);
            FindObjectOfType<AudioManager>().Play("wakawaka");
        }
    }
}
