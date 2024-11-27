using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mover_plataforma : MonoBehaviour
{

    private CharacterController cc_plataforma;

    private float f_velocidad_plataforma = 5f;

    public Vector3 v3_mov_plafatorma;

    public Gestion_estados moverse;

    private Vector3 v3_inicio_plataforma;

    private float f_tiempo_smooth = 4.00F;

    private Vector3 v3_velocidad_smooth = Vector3.zero;


    // Start is called before the first frame update
    void Start()
    {

        cc_plataforma = GetComponent<CharacterController>();
        v3_inicio_plataforma = cc_plataforma.transform.position;





    }

    // Update is called once per frame
    void Update()
    {
        //movimiento plataforma
        if (moverse.b_tocando == true)
        {

            cc_plataforma.Move(v3_mov_plafatorma * Time.deltaTime * f_velocidad_plataforma);
        }
        else
        {
            //plataforma vuelva a posicion original
            transform.position = Vector3.SmoothDamp(transform.position, v3_inicio_plataforma, ref v3_velocidad_smooth, f_tiempo_smooth);

        }



    }




}
