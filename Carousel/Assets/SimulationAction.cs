using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.SceneManagement;

public class SimulationAction : MonoBehaviour
{
    public InputField InStartAngel; // Поле для ввода стартового угла
    public InputField InSpeed; // Поле для ввода скорости поворота
    public InputField InTime; // Поле для ввода времени работы
    public Slider InHorseK; // Слайдер для указания начального положения лошадок 

    public void Start() // Подставляем значения в начальный экран
    {
        InStartAngel.text = (GlobalVars.state_degree).ToString();
        InSpeed.text = (GlobalVars.speed).ToString();
        InTime.text = (GlobalVars.time).ToString();
        InHorseK.value = (float)(GlobalVars.state / (float)Math.PI);
    }

    public void onInStartAngelChanged() // Метод вызываемый при вводе значения стартового угла
    {
        if (InStartAngel.text != "")
            GlobalVars.state_degree = (float)Convert.ToDouble(InStartAngel.text);
    }

    public void onInSpeedChanged() // Метод вызываемый при вводе значения скорости поворота
    {
        if (InSpeed.text != "")
            GlobalVars.speed = (float)Convert.ToDouble(InSpeed.text);
    }

    public void onInTimeChanged() // Метод вызываемый при вводе значения времени
    {
        if (InTime.text != "")
            GlobalVars.time = (float)Convert.ToDouble(InTime.text);
    }

    public void onInHorseKChanged() // Метод вызываемый при изменении значения положения лошадок
    {
        GlobalVars.state = (float)Convert.ToDouble(InHorseK.value) * (float)Math.PI;
    }

    public void Run() // Загружаем следующую сцену
    {
        SceneManager.LoadScene("SampleScene");
    }
}