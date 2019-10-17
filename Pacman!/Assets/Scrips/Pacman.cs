using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pacman : MonoBehaviour
{
    public float speed = 0.2f;
    private Vector2 dest = Vector2.zero;
    private int state = 1;

    // Start is called before the first frame update
    void Start()
    {
        dest = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector2 p = Vector2.MoveTowards(transform.position, dest, speed);
        GetComponent<Rigidbody2D>().MovePosition(p);

        if(Input.GetKey(KeyCode.UpArrow) && valid(Vector2.up))
        {
            state = 0;
            transform.eulerAngles = new Vector3(0, 0, 90);
        } else if(Input.GetKey(KeyCode.RightArrow) && valid(Vector2.right))
        {
            state = 1;
            transform.eulerAngles = new Vector2(0, 0);
        } else if (Input.GetKey(KeyCode.DownArrow) && valid(Vector2.down))
        {
            state = 2;
            transform.eulerAngles = new Vector3(0, 0, 270);
        } else if (Input.GetKey(KeyCode.LeftArrow) && valid(Vector2.left))
        {
            state = 3;
            transform.eulerAngles = new Vector2(0, 180);
        }

        switch (state)
        {
            case 0:
                dest = (Vector2)transform.position + Vector2.up;
                break;
            case 1:
                dest = (Vector2)transform.position + Vector2.right;
                break;
            case 2:
                dest = (Vector2)transform.position + Vector2.down;
                break;
            case 3:
                dest = (Vector2)transform.position + Vector2.left;
                break;
        }

    }

    bool valid(Vector2 dir)
    {
        Vector2 pos = transform.position;
        RaycastHit2D hit = Physics2D.Linecast (pos + dir, pos);
        return (hit.collider == GetComponent<Collider2D>());
    }
}
