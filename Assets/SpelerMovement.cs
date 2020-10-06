using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnityEngine;

public class SpelerMovement : MonoBehaviour
{

    public float beweegSpd = 12f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Roept de functie spring
        Spring();

        //Als de horizontalen knoppen worden ingedrukt, dan wordt er een kracht bij de transform position opgeteld.
        Vector3 bewegen = new Vector3(Input.GetAxis("Horizontal"), 0f, 0f);
        transform.position += bewegen * Time.deltaTime * beweegSpd;
    }

    //Dit is een fuctie die heeft spring.
    void Spring()
    {
        //Als de jump knoppen worden ingedruk, dan wordt er een kracht van float 5 aan de RigidBody2D van de speler gegeven.
        if (Input.GetKeyUp("up") || Input.GetKeyUp("w"))
        {
            gameObject.GetComponent<Rigidbody2D>().AddForce(new Vector2(0f, 15f), ForceMode2D.Impulse);
        }
    }
}
