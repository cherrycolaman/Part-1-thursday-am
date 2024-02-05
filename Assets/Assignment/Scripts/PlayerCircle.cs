using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCircle : MonoBehaviour
{
    Vector2 direction;
    public Rigidbody2D rigidbody;
    // Force is the amount the player is moved (the magnitude)
    public float force = 200;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // The x and y components of the direction moved are based on the arrow key inputs
        direction.x = Input.GetAxis("Horizontal");
        direction.y = Input.GetAxis("Vertical");
    }
    private void FixedUpdate()
    {
        // Force is added based on the direction inputted by the arrow keys
        rigidbody.AddForce(direction * force * Time.deltaTime);
    }
}
