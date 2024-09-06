using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnahuacTeacher : GameMonoBehaviour
{
    private void Start()
    {
        AddEventListener<WinAnahuacRAffleEvent>(WinRaffle);
    }

    public void WinRaffle(WinAnahuacRAffleEvent _event)
    {
        Debug.Log("GANE UNA RIFA WAOS SOY MAESTRO");
    }
}
