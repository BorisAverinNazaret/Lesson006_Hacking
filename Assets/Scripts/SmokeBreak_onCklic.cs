using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SmokeBreak_onCklic : MonoBehaviour
{
    public Text  btnI;
    public void OnCklic()
    {
        Hacking.FlagStartHacking = Hacking.FlagStartHacking ? false : true;
        btnI.text = Hacking.FlagStartHacking ? "Конец перекура" : "Перекур";
    }
}
