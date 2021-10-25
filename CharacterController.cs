using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour {
  public float speed = 10.0f;
  public float rotationSpeed = 100.0f;
  
  private Transform tf;
    
  void Awake() {
    tf = GetComponent<Transform>();
  }

  void Update() {
    float translationV = Input.GetAxis("Vertical1") * speed * Time.deltaTime;
    float translationH = Input.GetAxis("Horizontal1") * speed * Time.deltaTime;
    float rotation = Input.GetAxis("Up1") * rotationSpeed * Time.deltaTime;

    Vector3 translateVector = new Vector3(- translationV, 0, translationH);
    Vector3 rotateVector = rotation * Vector3.up;
    tf.Translate(translateVector);
    tf.Rotate(rotateVector);
  }
}
