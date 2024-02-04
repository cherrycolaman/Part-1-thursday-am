using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsSwitch : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
    public Color myColor;
    public GameObject ball;
    public Transform spawn;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = myColor;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        spriteRenderer.color = Color.green;
        Instantiate(ball, spawn.position, spawn.rotation);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        spriteRenderer.color = myColor;
    }
}
