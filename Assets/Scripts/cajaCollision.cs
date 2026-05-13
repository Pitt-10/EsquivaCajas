using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cajaCollision : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision col)
    {
	    if(col.gameObject.CompareTag("Caja"))
	     {
		    col.gameObject.GetComponent<cajaSpawner>().LocateBoxAtRandomPosition();	

            // aumenta velocidad de la caja
            col.gameObject.GetComponent<cajaMovement>().speed += 0.005f;
	     }
    }
}
