using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController2 : MonoBehaviour {
  public float speed = 10.0f;
  public float rotationSpeed = 100.0f;

  public static int score = 0;
  private Rigidbody rb;
  private Transform tf;

  void Awake() {
    rb = GetComponent<Rigidbody>();
    tf = GetComponent<Transform>();
  }

  void FixedUpdate() {
    Vector3 mInput = new Vector3(- Input.GetAxis("Vertical1"), 0f, Input.GetAxis("Horizontal1"));
    Vector3 rInput = Vector3.up * Input.GetAxis("Up1");
    Vector3 deltaPosition = transform.TransformDirection(mInput * Time.deltaTime * speed);
    Quaternion deltaRotation = Quaternion.Euler(rInput * Time.deltaTime * rotationSpeed);
    rb.MovePosition(rb.position + deltaPosition);
    rb.MoveRotation(rb.rotation * deltaRotation);
  }
}
