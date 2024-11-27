using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour
{
    
 
    GameObject go_objetivo;
    public float f_velocidad;
    Rigidbody rb_bala;
    // Start is called before the first frame update
    void Start()
    {
        rb_bala = GetComponent<Rigidbody>();
        go_objetivo = GameObject.FindGameObjectWithTag("Player");
        Vector3 direccion = (go_objetivo.transform.position - transform.position).normalized * f_velocidad;
        rb_bala.velocity = new Vector3(direccion.x, direccion.y);
        Destroy(this.gameObject, 2);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

  
}
