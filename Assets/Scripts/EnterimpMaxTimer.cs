using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnterimpMaxTimer : MonoBehaviour
{
    [SerializeField] private InputField inpMaxTimer;
    [SerializeField] private Text       txtTimer;

    public void OnChang()
    {
        txtTimer.text = inpMaxTimer.text;
    }

    public void Finish_inpMaxTimer()
    {
        // Коррекция после ввода пользователя и присвоение таймеру

        if (Convert.ToInt32(inpMaxTimer.text) < 1 )     inpMaxTimer.text = "1000";
        if (Convert.ToInt32(inpMaxTimer.text) > 50000)     inpMaxTimer.text = "50000";

        txtTimer.text = inpMaxTimer.text;

        Hacking.floatMaxTimer       = float.Parse(inpMaxTimer.text); // - Hacking.floatStartTimer
        Hacking.FlagStartHacking    = true;
    }
}
