using System;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class CaruselScript : MonoBehaviour
{
    void Start()
    {
        transform.rotation = Quaternion.Euler(0, - GlobalVars.state_degree, 0); // Поворачиваем карусель на начальный угол
    }

    void Update()
    {
        if (GlobalVars.time >= 0) // Если время не закончилось, то вычетаем время последнего кадра из оставшегося времени и перерасчитываем текущий угол
        {
            GlobalVars.time -= Time.deltaTime;
            GlobalVars.degrees = (GlobalVars.degrees + Time.deltaTime * GlobalVars.speed) % 360;
        }
        else // Иначе, переходим к следующей сцене
        {
            SceneManager.LoadScene("EndScene");
        }
        transform.rotation = Quaternion.Euler(0, -GlobalVars.degrees, 0); // Поворачиваем карусель
    }
}
