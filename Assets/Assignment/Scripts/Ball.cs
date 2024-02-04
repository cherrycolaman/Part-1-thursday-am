using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    SpriteRenderer spriterenderer;
    public Color ballColor;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
        spriterenderer = GetComponent<SpriteRenderer>();
        spriterenderer.color = ballColor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        spriterenderer.color = Color.blue;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        spriterenderer.color = ballColor;
    }
}
