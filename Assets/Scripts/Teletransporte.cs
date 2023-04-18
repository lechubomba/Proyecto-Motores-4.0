using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teletransporte : MonoBehaviour
{

    public Transform Objetivo;
    public GameObject Jugador;


    private void OneTriggerEnter(Collider other)
    {

        Jugador.transform.position=Objetivo.transform.position;

    }




}
