using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{

  public GameObject currentPlanet;
  public Vector3 targetPlanet;
  public float speed;




  // Start is called before the first frame update
  void Start()
   {
       
   }

  // Update is called once per frame
  void Update()
  {
    if (currentPlanet != null)
    {
      targetPlanet = new Vector3(currentPlanet.GetComponent<Transform>().position.x, currentPlanet.GetComponent<Transform>().position.y);
      //Debug.Log(targetPlanet.position);
      transform.position = Vector3.MoveTowards(transform.position, targetPlanet, Time.deltaTime * speed);

    }
     
  }

  void OnTriggerEnter2D(Collider2D other)
  {
    if(other.CompareTag("planet"))
    {
      Debug.Log("Collision entered!");
      currentPlanet = other.gameObject;
    }
  }

    
}
