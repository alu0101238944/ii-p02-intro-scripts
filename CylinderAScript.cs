using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderAScript : MonoBehaviour {
  private Transform tf;
  private Rigidbody rb;
  public float power = 1.0f;

  void Awake() {
    tf = GetComponent<Transform>();
    rb = GetComponent<Rigidbody>();
  }

  void FixedUpdate() {
    if (Input.GetKey("space")) {
      Vector3 distanceV = tf.position - GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>().position;
      rb.AddForce(power * distanceV);
    }
  }
}
