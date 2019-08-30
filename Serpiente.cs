﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Serpiente : MonoBehaviour {

    public GameObject Bloque;
    public GameObject Escenario;
    public int Ancho, Alto;

    private void Awake()
    {
        CrearMuros();
    }

    private void CrearMuros()
    {

        for (int x = 0; x < Ancho; x++)
        {
            for (int y = 0; y < Alto; y++)
            {
                Vector3 posicion = new Vector3(x, y);
                Instantiate(Bloque, posicion, Quaternion.identity, Escenario.transform);
            }
        }

}
