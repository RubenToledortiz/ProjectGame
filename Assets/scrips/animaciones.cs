using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animaciones : MonoBehaviour
{
     public Animator anim_animacion;
    public Transform enemigo;
    public Transform p1;
     public Transform p2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (enemigo.position.x == p1.position.x){

 anim_animacion.SetBool("b_mirror", true);
            
        } else if (enemigo.position.x == p2.position.x) {
 anim_animacion.SetBool("b_mirror", false);

        }
    }
}
