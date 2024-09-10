using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alumno : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        EventManager.m_Instance.AddListener<NoLlegoElProfeEvent>(MeVoyACasa);
    }

    public void MeVoyACasa(NoLlegoElProfeEvent _event){
        Debug.Log("Me voy a casa");
    }
}
