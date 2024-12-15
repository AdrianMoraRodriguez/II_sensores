# Práctica de sensores
## Adrián Mora Rodríguez

---

### Ejercicio 1: Mostrar en la UI los valores de Velocidad angular, Aceleración, Altitud y gravedad, Longitud y Latitud

#### Objetivo:
El objetivo de este ejercicio era crear una aplicación en Unity que muestre en la UI los valores en tiempo real de diferentes parámetros obtenidos a través de los componentes del dispositivo móvil, tales como la velocidad angular, la aceleración, la altitud, la gravedad, así como las coordenadas geográficas (latitud y longitud) obtenidas a través del GPS.

#### Pasos realizados:
1. **Velocidad angular**: Para obtener la velocidad angular del dispositivo, se utilizó la clase `Input.gyro` de Unity, que proporciona la actitud del dispositivo (orientación). A través de esta clase se puede obtener información sobre cómo se está moviendo el dispositivo en el espacio, es decir, cómo cambia su orientación con el tiempo.
  
2. **Aceleración**: La aceleración se obtiene mediante la clase `Input.acceleration`, que proporciona los valores de aceleración del dispositivo en los tres ejes (X, Y, Z). Este valor refleja cómo se está moviendo el dispositivo en relación con el espacio.

3. **Altitud y Gravedad**: Utilizando la clase `Input.location`, se obtuvo la altitud del dispositivo. Esta clase también nos proporciona información sobre la precisión de la ubicación y permite saber si el dispositivo tiene habilitado el servicio de localización.

4. **Latitud y Longitud**: Al llamar a `Input.location.lastData`, se obtuvieron los valores de latitud y longitud del dispositivo, que indican su ubicación geográfica actual. Estos valores cambian dinámicamente a medida que el dispositivo se mueve.

5. **UI en Unity**: Para mostrar estos valores en la interfaz de usuario de la aplicación, se crearon textos dinámicos en la pantalla que se actualizaban cada vez que los valores de estos parámetros cambiaban.

#### Resultados obtenidos:
Se realizó una medición de los valores tanto en el centro de cálculo como en el jardín de la ESIT. Los valores obtenidos se mostraron en tiempo real en la interfaz de usuario. A continuación, se incluyen los resultados obtenidos:

- **Centro de cáculo**:
  - Velocidad angular: (-0.41, -0.06, -0.14)
  - Aceleración: (-0.4, -0.96, -0.51)
  - Altitud: 612.7382
  - Gravedad: (-0.03, -0.88, -0.48)
  - Longitud: -16.32179
  - Latitud: 28.4829

- **Jardín de la ESIT**:
  - Velocidad angular: (-0.14, -0.47, -0.42)
  - Aceleración: (-0.3, -0.89, -0.56)
  - Altitud: 605.4666
  - Gravedad: (-0.01, -0.87, -0.50)
  - Longitud: -16.32151
  - Latitud: 28.48296
---
![Ejecución](https://github.com/AdrianMoraRodriguez/II_sensores/blob/main/sensores1.jpg)
![Ejecución](https://github.com/AdrianMoraRodriguez/II_sensores/blob/main/sensores2.jpg)
---

### Ejercicio 2: Crear una APK para orientar al samurái, avanzar con aceleración y detenerlo fuera de un rango específico de latitud y longitud

#### Objetivo:
En este ejercicio, el objetivo era crear una APK en Unity que controlara el movimiento de un samurái en la escena. Este samurái debía estar orientado siempre hacia el norte, avanzar según la aceleración del dispositivo y detenerse si el dispositivo se encontraba fuera de un rango específico de latitud y longitud. 

#### Pasos realizados:
1. **Orientación hacia el norte**: Para garantizar que el samurái siempre estuviera orientado hacia el norte, se utilizó la brújula del dispositivo, obtenida a través de la clase `Input.compass.trueHeading`. Este valor se utilizó para orientar al samurái en la escena de Unity, manteniendo siempre la dirección correcta.

2. **Movimiento con aceleración**: Se utilizó el acelerómetro del dispositivo (`Input.acceleration`) para medir la aceleración del dispositivo en el eje Z (el eje hacia adelante y hacia atrás). Con esta información, se controló la velocidad y dirección del movimiento del samurái, haciendo que avanzara o retrocediera dependiendo de la inclinación del dispositivo.

3. **Inversión del valor Z**: Debido a la forma en que Unity maneja los sistemas de coordenadas, el valor del eje Z obtenido del acelerómetro fue invertido, ya que la orientación del sistema de coordenadas de Unity no coincidía con la forma en que el dispositivo estaba orientado. Esto se corrigió invirtiendo el valor de la aceleración en el eje Z.

4. **Interpolación de rotaciones**: Para suavizar las rotaciones del samurái y evitar movimientos bruscos, se utilizó la interpolación esférica (`Quaternion.Slerp`) para rotar al samurái de manera gradual hacia la orientación correcta.

5. **Detención fuera de un rango geográfico**: El samurái se detuvo cuando el dispositivo se encontraba fuera de un rango de latitud y longitud específico. Esto se implementó verificando la ubicación del dispositivo utilizando `Input.location.lastData.latitude` y `Input.location.lastData.longitude`. Si el dispositivo salía de los límites establecidos, el movimiento del samurái se detenía.

#### Resultados obtenidos:  

![Ejecución](https://github.com/AdrianMoraRodriguez/II_sensores/blob/main/samurai.gif)
