using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cajaMovement : MonoBehaviour
{

    public float speed;

    public gameTimer timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, -speed, 0);
    }


    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.CompareTag("Player"))
        {
            speed = 0f;

            timer.gameOver = true;
        }
    }
}
