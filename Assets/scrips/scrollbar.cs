using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scrollbar : MonoBehaviour
{
    public Gestion_estados ge;

    public Scrollbar scroll;

    public double tamano = 0;


    // Start is called before the first frame update
    void Start()
    {

        scroll = GetComponent<Scrollbar>();

  
      
    }

    // Update is called once per frame
    void Update()
    {
        
        scroll.size = (float)tamano;

        if (ge.b_derecha == true)
        {

            tamano = (tamano + 0.000460);
        }

        if (ge.b_izquierda == true)
        {
            tamano = (tamano - 0.000460);
        }

       
    }

}
