using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GlobalVars : MonoBehaviour
{
    public static float degrees = 0; // Текущий угол системы (град.)
    public static float radius = 60.0f; // Расстояние от центра системы до лошадки (усл. м.)
    public static float swing = 90.0f; // Угол между лошадками (град.)
    public static float step = 16.0f; // Максимальное отклонение по оси Z (усл. м.)

    public static float state_degree = 00.0f; // Начальный угол системы
    public static float speed = 60.0f; // Желаемая скорость вращения системы (град./сек.)
    public static float time = 300.0f; // Время работы системы (сек.)  
    public static float state = 0.2f * (float)Math.PI; // Коэфициент положения лошадки
}
