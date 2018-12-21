using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

  public Transform target;
  public float smoothSpeed;
  public Vector3 offset;
  public Vector3 desiredPosition;
  public Vector3 smoothedPosition;
  // Use this for initialization
  void Start()
  {
    smoothSpeed = .25f;
    offset = new Vector3(0f, 2f, -10f);
  }

  // Update is called once per frame
  void LateUpdate()
  {
    desiredPosition = target.position + offset;
    smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
    transform.position = smoothedPosition;

  }
}
