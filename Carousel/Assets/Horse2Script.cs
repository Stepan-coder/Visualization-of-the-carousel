using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Horse2Script : MonoBehaviour
{
    float posy; // Переменная хранящая позицию по "у"
    void Start()
    {
        posy = transform.position.y; // Запоминаем начальное положение по "у"
        RotateHorse(-GlobalVars.state_degree + GlobalVars.swing * 1); // Поворачиваем лошадку на начальный угол 
    }

    void Update()
    {
        RotateHorse((GlobalVars.degrees + GlobalVars.swing * 1 + 5) % 360); // Поворачиваем лошадку на текущий угол (производим корректировку угла)
    }

    void RotateHorse(float angle)
    {
        float rad_angle = (float)Math.PI * angle / 180.0f; // Переводим текущий угол системы в радианы
        float x = GlobalVars.radius * (float)Math.Cos(rad_angle); // Расчитываем новое положение лошадки по "х"
        float y = GlobalVars.radius * (float)Math.Sin(rad_angle); // Расчитываем новое положение лошадки по "у"
        transform.position = new Vector3(x, posy + GlobalVars.step * (float)Math.Cos(rad_angle + GlobalVars.state), y); // Перемещаем лошадку в новые координаты
        transform.rotation = Quaternion.Euler(90, -GlobalVars.degrees + 7, GlobalVars.swing * 2); // Поворачиваем лошадку на угол
    }
}
