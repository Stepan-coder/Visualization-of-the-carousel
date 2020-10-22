using System;
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;


public class EndScript : MonoBehaviour
{
    public Text myText1;
    public Text myText2;
    public Text myText3;
    public Text myText4;
    // Start is called before the first frame update
    void Start()
    {
        float horse1_angle = (GlobalVars.state_degree + GlobalVars.speed * GlobalVars.time + GlobalVars.swing * 0) % 360;
        float horse1_state = (float)Math.Cos((float)Math.PI * horse1_angle / 180.0f + GlobalVars.state);
        float horse1_x = GlobalVars.radius * (float)Math.Cos((float)Math.PI * horse1_angle / 180.0f);
        float horse1_y = GlobalVars.radius * (float)Math.Sin((float)Math.PI * horse1_angle / 180.0f);
        float horse1_z = GlobalVars.step * horse1_state;
        myText1.text = "Лошадка 1 (x= " + Math.Round(horse1_x, 2).ToString() + ", y=" + Math.Round(horse1_y, 2).ToString() + ", z=" + Math.Round(horse1_z, 2).ToString() +  ", α=" + Math.Round(horse1_angle, 2).ToString() + ", β =" + Math.Round(horse1_state, 2).ToString() + ")";
        
        float horse2_angle = (GlobalVars.state_degree + GlobalVars.speed * GlobalVars.time + GlobalVars.swing * 1) % 360;
        float horse2_state = (float)Math.Cos((float)Math.PI * horse2_angle / 180.0f + GlobalVars.state);
        float horse2_x = GlobalVars.radius * (float)Math.Cos((float)Math.PI * horse2_angle / 180.0f);
        float horse2_y = GlobalVars.radius * (float)Math.Sin((float)Math.PI * horse2_angle / 180.0f);
        float horse2_z = GlobalVars.step * horse2_state;
        myText2.text = "Лошадка 2 (x= " + Math.Round(horse2_x, 2).ToString() + ", y=" + Math.Round(horse2_y, 2).ToString() + ", z=" + Math.Round(horse2_z, 2).ToString() + ", α=" + Math.Round(horse2_angle, 2).ToString() + ", β =" + Math.Round(horse2_state, 2).ToString() + ")";

        float horse3_angle = (GlobalVars.state_degree + GlobalVars.speed * GlobalVars.time + GlobalVars.swing * 2) % 360;
        float horse3_state = (float)Math.Cos((float)Math.PI * horse3_angle / 180.0f + GlobalVars.state);
        float horse3_x = GlobalVars.radius * (float)Math.Cos((float)Math.PI * horse3_angle / 180.0f);
        float horse3_y = GlobalVars.radius * (float)Math.Sin((float)Math.PI * horse3_angle / 180.0f);
        float horse3_z = GlobalVars.step * horse3_state;
        myText3.text = "Лошадка 3 (x= " + Math.Round(horse3_x, 2).ToString() + ", y=" + Math.Round(horse3_y, 2).ToString() + ", z=" + Math.Round(horse3_z, 2).ToString() + ", α=" + Math.Round(horse3_angle, 2).ToString() + ", β =" + Math.Round(horse3_state, 2).ToString() + ")";


        float horse4_angle = (GlobalVars.state_degree + GlobalVars.speed * GlobalVars.time + GlobalVars.swing * 3) % 360;
        float horse4_state = (float)Math.Cos((float)Math.PI * horse4_angle / 180.0f + GlobalVars.state);
        float horse4_x = GlobalVars.radius * (float)Math.Cos((float)Math.PI * horse4_angle / 180.0f);
        float horse4_y = GlobalVars.radius * (float)Math.Sin((float)Math.PI * horse4_angle / 180.0f);
        float horse4_z = GlobalVars.step * horse4_state;
        myText4.text = "Лошадка 4 (x= " + Math.Round(horse4_x, 2).ToString() + ", y=" + Math.Round(horse4_y, 2).ToString() + ", z=" + Math.Round(horse4_z, 2).ToString() + ", α=" + Math.Round(horse4_angle, 2).ToString() + ", β =" + Math.Round(horse4_state, 2).ToString() + ")";

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
