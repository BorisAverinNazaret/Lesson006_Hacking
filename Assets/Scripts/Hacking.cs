using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static SBS;



public class Hacking : MonoBehaviour
{

    [SerializeField] private Text         txtTimer;
    [SerializeField] public InputField    inpMaxTimer;
    [SerializeField] public static bool   FlagStartHacking = false;


    public static float floatMaxTimer = 0f;     // время оставшееся
    public static float floatCurrentTime = 0f;   // текущее время
    private float i = 0f;

    void Start(){ Debug.Log(Time.realtimeSinceStartup); }

    void Update()
    {
        // Debug.Log("Time.time= " + Convert.ToString(Time.time));
        if (FlagStartHacking)
        {
            floatCurrentTime = Mathf.Round(Time.realtimeSinceStartup); //   * Time.deltaTime
            if (i != floatCurrentTime)
            {
                i = floatCurrentTime;
                floatMaxTimer--;

                txtTimer.text = Convert.ToString(floatMaxTimer);
            }
         }
    }
}
