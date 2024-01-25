using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oil : MonoBehaviour
{
    public Car car;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void OnTriggerEnter2D(Collider2D collision)
    {
        car.forwardSpeed = 100;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        car.forwardSpeed = 500;
    }
}
