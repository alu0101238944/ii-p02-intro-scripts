using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController3 : MonoBehaviour {
  public float speed = 10.0f;

  private Rigidbody rb;
  private Transform tf;

  void Awake() {
    rb = GetComponent<Rigidbody>();
    tf = GetComponent<Transform>();
  }

  void OnCollisionEnter(Collision collision) {
    Debug.Log("Colisión detectada con: " + collision.gameObject.name);
  }

  void FixedUpdate() {
    Vector3 mInput = new Vector3(- Input.GetAxis("Vertical2"), 0f, Input.GetAxis("Horizontal2"));
    Vector3 deltaPosition = transform.TransformDirection(mInput * Time.deltaTime * speed);
    rb.MovePosition(rb.position + deltaPosition);
  }
}
