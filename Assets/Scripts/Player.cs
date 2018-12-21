using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{

  public GameObject currentPlanet;
  public Vector3 targetPlanet;
  public float speed;

  public bool gravity;
  public bool isOnGround;
  //public bool planetEntered;


  // Start is called before the first frame update
  void Start()
   {
    speed = 9.8f;
    gravity = false;
    isOnGround = false;
   }

  // Update is called once per frame
  void Update()
  {
    //if (gravity == true)
    //{
    //  targetPlanet = new Vector3(currentPlanet.GetComponent<Transform>().position.x, currentPlanet.GetComponent<Transform>().position.y);
    //  planetGravity();
    //  //Debug.Log("Target set");
    //}
   
     
  }

  void LateUpdate()
  {
   // if(gravity == true)
   // transform.position = Vector3.MoveTowards(transform.position, targetPlanet, Time.deltaTime * speed);
  }

  //void planetGravity()
  //{
  //  if(isOnGround == false)
  //  {
  //    transform.position = Vector3.MoveTowards(transform.position, targetPlanet, Time.deltaTime * speed);
  //  }
  //}

  //void OnTriggerEnter2D(Collider2D other)
  //{
  //  if(other.CompareTag("gravity_core"))
  //  {
  //    Debug.Log("Player has entered gravitational pull of planet");
  //    gravity = true;
  //    currentPlanet = other.gameObject;
  //    Transform planet = currentPlanet.GetComponent<PlanetGravity>().transform;
  //    planet.A
      
  //  }
  //  else if(other.CompareTag("planet"))
  //  {
  //    isOnGround = true;
  //  }
  //}

  //void OnTriggerExit2D(Collider2D other)
  //{
  //  if (other.CompareTag("gravity_core"))
  //  {
  //    Debug.Log("Player has left gravitational pull of planet");
  //    gravity = false;
  //    currentPlanet = null;
  //  }
  //  else if (other.CompareTag("planet"))
  //  {
  //    isOnGround = false;
  //  }

  //}

    
}
