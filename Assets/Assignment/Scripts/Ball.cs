using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    public Rigidbody2D rigidbody;
    // SpriteRenderer's default color is set to cyan
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
        // When the ball collides with another object, such as a wall, a player or another ball, it changess to dark blue
        spriterenderer.color = Color.blue;
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        // When not touching another object, the ball changes back to cyan
        spriterenderer.color = ballColor;
    }
}
