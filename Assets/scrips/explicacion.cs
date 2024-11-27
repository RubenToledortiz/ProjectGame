using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class explicacion : MonoBehaviour
{
    public GameObject exp;
    // Start is called before the first frame update
    void Start()
    {
        mostrar();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     public void mostrar()
    {
        StartCoroutine(explicar());
    }

    IEnumerator explicar()
    {
        
   exp.SetActive(true);
   yield return new WaitForSeconds(10);
   exp.SetActive(false);
    }
}
