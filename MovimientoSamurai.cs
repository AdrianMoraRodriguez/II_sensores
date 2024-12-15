using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoSamurai : MonoBehaviour
{

    public GameObject samurai;
    private float smoothing = 0.1f;
    private Quaternion initialRotation;
    void Start() {
      samurai = GameObject.Find("samuzai");
      Input.gyro.enabled = true;
      Input.location.Start();
      initialRotation = samurai.transform.rotation;
    }

    void orientSamurai() {
      Quaternion attitude = Input.gyro.attitude;
      samurai.transform.rotation = attitude;
      samurai.transform.Rotate(0f, 0f, 180f, Space.Self);
      samurai.transform.Rotate(90f, 180f, 0f, Space.World);
    }

    void moveSamurai() {
      float moveZ = Input.acceleration.z;
      moveZ = -moveZ;
      samurai.transform.Translate(Vector3.forward * moveZ * smoothing * Time.deltaTime * 5);
    }

    // Update is called once per frame
    void Update() {
      orientSamurai();
      moveSamurai();
    }
}
