using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class duracion_sonido : MonoBehaviour
{

    private float f_duracion = 2;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, f_duracion);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
