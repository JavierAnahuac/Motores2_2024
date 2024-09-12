using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Alumno : MonoBehaviour
{
    private Image imagen;

    void Start()
    {
        imagen = GetComponent<Image>();
        EventManager.m_Instance.AddListener<NoLlegoElProfeEvent>(MeVoyACasa);
        EventManager.m_Instance.AddListener<NoHayClaseEvent>(MeQuedoEnCasa);
    }

    public void MeVoyACasa(NoLlegoElProfeEvent _event){
        object[] parameters = _event.GetParameters();
        Debug.Log("Me voy a casa por que no llego el profe de" + parameters[0]);
        imagen.color = (Color)parameters[1];
    }

    private void MeQuedoEnCasa(NoHayClaseEvent _event) {
        Debug.Log("Jugare genshin");
    }
}
