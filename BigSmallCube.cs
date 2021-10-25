using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigSmallCube : MonoBehaviour {
  public float power = 5.0f;

  private SphereCollider sphereCollider;
  private Vector3 originalSize;
  private float radius;

  void Awake() {
    sphereCollider = GetComponent<SphereCollider>();
    originalSize = transform.localScale;
    radius = sphereCollider.radius * originalSize.x;
  }

  void OnTriggerStay(Collider anotherCollide) {
    string tag = anotherCollide.gameObject.tag;
    if (tag == "Sphere" || tag == "Player") {
      Vector3 anotherPos = anotherCollide.gameObject.transform.position;
      float distance = Vector3.Distance(anotherPos, transform.position);
      if (distance < radius) {
        float scaleAmount = (tag == "Player" ? -1 : 1) * (1 - distance / radius) * power;
        transform.localScale = originalSize + scaleAmount * Vector3.one;
      }
    }
  }
}
