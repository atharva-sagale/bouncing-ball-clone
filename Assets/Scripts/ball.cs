using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{

    Rigidbody2D rb;
    public float bounceForce;
    bool once = true;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "fallcheck")
        {
            GameManager.instance.Reset();
        }
        else if (collision.gameObject.tag == "pad")
        {
            GameManager.instance.ScoreUp();
            bounce();
        }
    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
    }

    void bounce()
    {
        Vector2 randomDir = new Vector2(Random.Range(-1, 1), 1);

        rb.AddForce(randomDir * bounceForce, ForceMode2D.Impulse);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            if(once)
            {
                once = false;
                rb.gravityScale = 1;
                GameManager.instance.gamestartUI.SetActive(false);
                GameManager.instance.scoreboard.SetActive(true);
            }
        }
    }
}
