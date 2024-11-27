using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gestion_estados : MonoBehaviour
{
    public bool b_android = false;
    public GameObject go_cnv_android;
    public FixedJoystick fjDireccio;
    public FixedJoystick fjDireccioPlat;
    public GameObject player;
public GameObject plataforma;
public GameObject enemigo;
public GameObject decorado;
public GameObject enemigo2;
public GameObject enemigo3;
public GameObject luz;
public GameObject contador;
public GameObject barra;
public GameObject checkpoint;
public GameObject cam;
public GameObject minimapa;
public GameObject barrera;
public GameObject expli;
    public bool b_tocando = false;

    public bool b_arriba = false;


    //enrerre
    public bool b_abajo = false;


    //esquerra
    public bool b_esquerra = false;


    //dreta
    public bool b_dreta = false;


    //bot
    public bool b_bot = false;

    public bool b_derecha = false;

    public bool b_izquierda = false;

    // Start is called before the first frame update
    void Start()
    {
        b_android = Input.touchSupported;
    }

    // Update is called once per frame
    void Update()
    {



        if (b_android == false)
        {
            go_cnv_android.SetActive(true);
            if (fjDireccio.Horizontal > fjDireccio.DeadZone)
                b_derecha = true;
            else
                b_derecha = false;
            if (fjDireccio.Horizontal < -fjDireccio.DeadZone)
                b_izquierda = true;
            else
                b_izquierda = false;

            if (fjDireccioPlat.Horizontal > fjDireccioPlat.DeadZone)
                b_dreta = true;
            else
                b_dreta = false;
            if (fjDireccioPlat.Horizontal < fjDireccioPlat.DeadZone)

                b_esquerra = true;
            else
                Debug.Log("izquierda");
            b_esquerra = false;
            if (fjDireccioPlat.Vertical > fjDireccioPlat.DeadZone)
                b_arriba = true;
            else
                b_arriba = false;
            if (fjDireccioPlat.Vertical < -fjDireccioPlat.DeadZone)
                b_abajo = true;
            else
                b_abajo = false;


player.SetActive(false);
plataforma.SetActive(false);
enemigo.SetActive(false);
enemigo2.SetActive(false);
enemigo3.SetActive(false);
luz.SetActive(false);
decorado.SetActive(false);
contador.SetActive(false);
checkpoint.SetActive(false);
cam.SetActive(false);
minimapa.SetActive(false);
barrera.SetActive(false);
expli.SetActive(false);
barra.SetActive(false);
        }

        else
        { //PC
            go_cnv_android.SetActive(false);


            if (Input.GetKeyDown(KeyCode.K))
                b_dreta = true;

            if (Input.GetKeyDown(KeyCode.H))
                b_esquerra = true;

            if (Input.GetKeyDown(KeyCode.U))
                b_arriba = true;

            if (Input.GetKeyDown(KeyCode.J))
                b_abajo = true;
            if (Input.GetKeyDown(KeyCode.Space))
                b_bot = true;
            else
                b_bot = false;

           if (Input.GetKey(KeyCode.RightArrow))
                b_derecha = true;
            else
                b_derecha = false;
            if (Input.GetKey(KeyCode.LeftArrow))
                b_izquierda = true;
            else
                b_izquierda = false;



        }

        if (Input.GetKeyUp(KeyCode.U))
        {
            b_arriba = false;

        }
        else if (Input.GetKeyUp(KeyCode.J))
        {
            b_abajo = false;
        }

        else if (Input.GetKeyUp(KeyCode.K))
        {
            b_dreta = false;
        }
        else if (Input.GetKeyUp(KeyCode.H))
        {
            b_esquerra = false;

        }

    }

    //comprobar si el personaje esta sobre la plataforma

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (hit.transform.tag == "mover_plataforma")
        {
            b_tocando = true;
        }
        else
        {
            b_tocando = false;
        }
    }


    public void Fer_Un_Bot()
    {
        b_bot = true;
    }


}
