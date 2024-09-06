using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnahuacStudent : GameMonoBehaviour
{

    private void Start()
    {
        AddEventListener<WinAnahuacRAffleEvent>(WinRaffle);
    }

    public void WinRaffle(WinAnahuacRAffleEvent _event)
    {
        Debug.Log("GANE UNA RIFA WAOS");
    }
}
