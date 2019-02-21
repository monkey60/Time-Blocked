﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoDetectorBarra : MonoBehaviour
{
    Vector2 posicionRaton;
    public Transform trBarra;
    public float dureza = 0.25f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        posicionRaton.y = trBarra.position.y;
        trBarra.position = Vector2.MoveTowards(trBarra.position, posicionRaton, dureza);
       
    }
    private void OnMouseOver()
    {
        posicionRaton = Camera.main.ScreenToWorldPoint(Input.mousePosition);
    }
    private void OnMouseEnter()
    {
        if (Input.touchCount == 2)
        {
            Movimiento.lanza = true;

        }

    }
}
