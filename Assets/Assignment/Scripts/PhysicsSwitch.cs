using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsSwitch : MonoBehaviour
{
    // SpriteRenderer is called so the switch can change color
    SpriteRenderer spriteRenderer;
    // Default color is set to purple
    public Color myColor;
    // A ball GameObject and a spawn point are added as variables so the ball prefab can spawn from the spawn point
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
        // When something enters the switch, it changes to green and a ball prefab is instantiated at spawn, above the wall
        spriteRenderer.color = Color.green;
        Instantiate(ball, spawn.position, spawn.rotation);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        // When the object leaves the switch, it changes back to purple
        spriteRenderer.color = myColor;
    }
}
