using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class paddle : MonoBehaviour
{
    Rigidbody2D rb;
    public float speed;

    void touchMove()
    {
        if (Input.GetMouseButton(0))
        {
            Vector2 touchpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if(touchpos.x < 0)
            {
                rb.velocity = Vector2.left * speed;
            }
            else
            {
                rb.velocity = Vector2.right * speed;
            }
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
    }

    private void Awake() {
        rb = GetComponent<Rigidbody2D>();    
    }

    private void FixedUpdate()
    {
        touchMove();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
