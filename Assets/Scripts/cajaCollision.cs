using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cajaCollision : MonoBehaviour
{
    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.CompareTag("Caja"))
        {
            col.gameObject.GetComponent<cajaSpawner>().LocateBoxAtRandomPosition();

            col.gameObject.GetComponent<cajaMovement>().speed += 0.02f;
        }
    }
}