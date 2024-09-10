using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

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

    public void OnClick_NoLlegoElProfeEvent()
    {
        EventManager.m_Instance.InvokeEvent<NoLlegoElProfeEvent>(new NoLlegoElProfeEvent());
    }

}
