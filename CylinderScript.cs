using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderScript : MonoBehaviour {
  private Transform tf;
  public float scale = 0.25f;

  void Awake() {
    tf = GetComponent<Transform>();
  }

  void OnCollisionEnter(Collision collision) {
    if (collision.gameObject.tag == "Player") {
      tf.localScale += Vector3.one * scale;
      Debug.Log(collision.gameObject.name + ": " + ++CharacterController2.score);
    }
  }
}
