using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class disparar : MonoBehaviour
{
    public GameObject go_projectil;
    public Transform t_punt_dispar;
    public float t_temps = 15f;

    private void OnEnable()
    {
        Invoke("Desactiva", t_temps);
    }

    void Desactiva()
    {
        GetComponent<disparar>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
            Instantiate(go_projectil, t_punt_dispar.position, t_punt_dispar.rotation);
    }
}
