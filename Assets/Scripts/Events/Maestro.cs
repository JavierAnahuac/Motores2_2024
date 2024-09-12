using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Maestro : MonoBehaviour
{
    private Image imagen;

    void Start()
    {
        imagen = GetComponent<Image>();
        EventManager.m_Instance.AddListener<NoLlegoElProfeEvent>(MeVoyACasa);
    }

    public void MeVoyACasa(NoLlegoElProfeEvent _event)
    {
        object[] parameters = _event.GetParameters();
        Debug.Log("Soy profe de " + parameters[0] + "Reportar que estoy enfermo");
        imagen.sprite = (Sprite)parameters[2];
    }
}
