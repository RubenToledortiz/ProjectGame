using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover_camara : MonoBehaviour
{
    public GameObject player1;
    private Vector3 v3_posicion_camara;
    private float f_tiempo_smooth = 0.2F;
    private Vector3 v3_velocidad_smooth = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        //coger la posicion inicial de la camara
        v3_posicion_camara = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //la X y la Y de la camara son las del personaje
        v3_posicion_camara.x = player1.transform.position.x;
        v3_posicion_camara.y = player1.transform.position.y;
        transform.position = Vector3.SmoothDamp(transform.position, v3_posicion_camara, ref v3_velocidad_smooth, f_tiempo_smooth);




    }
}
