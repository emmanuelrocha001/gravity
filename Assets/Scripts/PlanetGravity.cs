using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetGravity : MonoBehaviour
{
    public float gravity = -10;
    public bool gravityOn = false;

    private void Start()
    {
        gravityOn = false;
    }


    //void OnTriggerEnter2D(Collider2D other)
    //{
    //    if (other.CompareTag("Player"))
    //    {
    //        Debug.Log("Player has entered gravitational pull of planet");
    //        gravityOn = true;


    //        Attract(other.gameObject.transform);


    //    }

    //}

    private void OnTriggerStay2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player has entered gravitational pull of planet");
            gravityOn = true;


            Attract(other.gameObject);


        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player has left gravitational pull of planet");
            gravityOn = false;
        }
        
        //else if (other.CompareTag("planet"))
        //{
        //    isOnGround = false;
        //}

    }

    public void Attract( GameObject body)
    {
        Debug.Log("Colliding");

        Vector2 gravityUp = (body.transform.position - transform.position).normalized;
        Vector2 bodyUp = body.transform.up;

        //Adds a force to the planet
        //body.GetComponent<Rigidbody2D>().AddForce(gravityUp * gravity);
        Debug.Log("Attracting");
        body.GetComponent<Rigidbody2D>().AddForce(gravityUp * gravity);
        Debug.Log(gravityUp.ToString());
       

        //Adds the rotation to face the planet
        Quaternion targetRotation = Quaternion.FromToRotation(bodyUp, gravityUp) * body.transform.rotation;
        body.transform.rotation = Quaternion.Slerp(body.transform.rotation, targetRotation, 50 * Time.deltaTime);
    }
}
