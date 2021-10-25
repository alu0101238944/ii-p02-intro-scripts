using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderBScript : MonoBehaviour {
  private Transform tf;
  private Rigidbody rb;
  public float power = 2.0f;
  public float distanceLimit = 4.0f;

  void Awake() {
    tf = GetComponent<Transform>();
    rb = GetComponent<Rigidbody>();
  }

  void FixedUpdate() {
    Vector3 playerPos = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>().position;
    Vector3 distanceV = tf.position - playerPos;
    if (Vector3.Distance(tf.position, playerPos) <= distanceLimit) {
      rb.AddForce(power * distanceV);
    }
  }
}
