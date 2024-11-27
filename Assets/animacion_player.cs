using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animacion_player : MonoBehaviour
{
 public Animator anim_animacion;
    public Gestion_estados ge;
     private Vector3 v3_mov_horizontal;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ge.b_derecha == true)
        {
            anim_animacion.SetBool("b_caminar",false);
            anim_animacion.SetFloat("velX",1);
            v3_mov_horizontal = new Vector3(1, 0, 0);
            
        }
        if (ge.b_derecha == false)
        {
            anim_animacion.SetBool("b_caminar",true);
            anim_animacion.SetFloat("velX",(float)0.3);
            v3_mov_horizontal = new Vector3(0, 0, 0);
        } else
        {
            anim_animacion.SetBool("b_caminar",false);

        }
        if (ge.b_izquierda == true)
        {
            anim_animacion.SetBool("b_caminar",false);
            anim_animacion.SetFloat("velX",-1);
            v3_mov_horizontal = new Vector3(-1, 0, 0);

        }
    }
}
