using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gestor_menus : MonoBehaviour


{
    public checkpoint ch;
    public menu_juego menu;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void seguir_partida(){

    
        SceneManager.LoadScene("SampleScene");
        Time.timeScale = 1;
    }


     public void nueva_partida(){
        SceneManager.LoadScene("SampleScene");
        PlayerPrefs.DeleteAll();
        Time.timeScale = 1;
    } 
    public void menu_salir(){

Application.Quit();
    }

    public void juego_red(){

SceneManager.LoadScene("SampleScene");
        PlayerPrefs.DeleteAll();
         Time.timeScale = 1;
    }

    public void volver_menu(){

SceneManager.LoadScene("menu principal");
 Time.timeScale = 1;
    }

    public void volver_juego(){
    menu.menu.SetActive(false);
    Time.timeScale = 1;
    }

   
}
