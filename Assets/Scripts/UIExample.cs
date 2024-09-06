using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.IO;
using Unity.IO.LowLevel.Unsafe;

public class UIExample : GameMonoBehaviour
{
    public TMP_Text scoreText;

    void Update()
    {
        scoreText.text = PointsManager.instance.GetScore().ToString();
    }

    public void OnClick_AddPoints()
    {
        PointsManager.instance.AddPoints(10);
    }

    public void OnClick_RemovePoints()
    {
        PointsManager.instance.RemovePoints(10);
    }

    public void OnClick_WinAnahuacEvent()
    {
        InvokeEvent<WinAnahuacRAffleEvent>(new WinAnahuacRAffleEvent());
    }

}
