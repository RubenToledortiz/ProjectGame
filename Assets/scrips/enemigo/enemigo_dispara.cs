using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemigo_dispara : MonoBehaviour
{
    public float f_velocidad;
    private Transform t_player;
    public float f_rango; // rango de disparo
    public float f_veldis = 1f; // velocidad de disparo
    private float f_proxdisparo;
    public GameObject go_bala;
    public GameObject go_balapadre;
    public bool b_giro;
    public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
      t_player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        //distancia con el jugador
        float f_distanciaconeljugador = Vector3.Distance(t_player.position, transform.position);

        // comprobar la distancia a la que esta para que dispare
        if (f_distanciaconeljugador <= f_rango && f_proxdisparo < Time.time)
        {
         //   anim;
            Instantiate(go_bala, go_balapadre.transform.position, Quaternion.identity);
            f_proxdisparo = Time.time + f_veldis;
           
            
        } else {

       
        }
       
        giro();

    }


    //girarlo 
     public void giro()
    {
        
            if (transform.position.x < t_player.transform.position.x )
            {
            transform.localScale = new Vector3(-1, 1,1);
            }
            else
            {
            transform.localScale = new Vector3(1, 1,1);
        }
}
}
