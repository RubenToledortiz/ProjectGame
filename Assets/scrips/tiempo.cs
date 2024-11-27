  using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tiempo : MonoBehaviour
{
 
//Variable para el tiempo 
	public float Tiempo = 0.0f;  

    public float contador;
	//Variable para asociar el objeto Texto Tiempo
	public Text textoTiempo;

	void Start () {

		//Inicializo el texto del contador de tiempo
		textoTiempo.text = "Tiempo: 00:00";

	}
	
	void Update () {
     contador = (Tiempo += Time.deltaTime);
		//Escribo tiempo transcurrido 
	  textoTiempo.text = "Tiempo: " + contador;
		
	}

}
