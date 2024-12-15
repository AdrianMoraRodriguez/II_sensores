using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class sensores : MonoBehaviour
{
  public TextMeshProUGUI velocidad_angular_text;
  public TextMeshProUGUI aceleracion_text;
  public TextMeshProUGUI altitud_text;
  public TextMeshProUGUI gravedad_text;
  public TextMeshProUGUI longitud_text;
  public TextMeshProUGUI latitud_text;

    // Start is called before the first frame update
  void Start() {
    Input.gyro.enabled = true;
    Input.location.Start();

  }

    // Update is called once per frame
  void Update() {
  velocidad_angular_text.text = "Velocidad angular: " + Input.gyro.rotationRateUnbiased.ToString();
  aceleracion_text.text = "Aceleracion: " + Input.acceleration.ToString();
  altitud_text.text = "Altitud: " + Input.location.lastData.altitude.ToString();
  gravedad_text.text = "Gravedad: " + Input.gyro.gravity.ToString();
  longitud_text.text = "Longitud: " + Input.location.lastData.longitude.ToString();
  latitud_text.text = "Latitud: " + Input.location.lastData.latitude.ToString();
  }
}
