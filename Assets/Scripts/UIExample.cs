using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UIExample : GameMonoBehaviour
{
    public TMP_Text scoreText;
    public Sprite eventSprite;

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

    public void OnClick_NoLlegoElProfeEvent()
    {
        object[] parameters = new object[3];
        parameters[0] = "Motores 2";
        parameters[1] = Color.red;
        parameters[2] = eventSprite;
        EventManager.m_Instance.InvokeEvent<NoLlegoElProfeEvent>(new NoLlegoElProfeEvent(parameters));

        EventManager.m_Instance.InvokeEvent<NoHayClaseEvent>(new NoHayClaseEvent());
    }

}
