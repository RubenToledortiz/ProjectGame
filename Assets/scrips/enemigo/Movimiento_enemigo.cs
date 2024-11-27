using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimiento_enemigo : MonoBehaviour
{

    // no esta acabado, son pruebas aun 
    public Transform t_enemigo;
    public Transform t_p1;
    public Transform t_p2;


    Vector3 v3_desti = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        v3_desti = t_p1.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (t_enemigo.position == t_p1.position)
            t_enemigo.transform.Rotate (0.0f, 180.0f, 0.0f, Space.World);
        if (t_enemigo.position == t_p2.position)
            t_enemigo.transform.Rotate(0.0f, -180.0f, 0.0f, Space.World);

 
    }
}
