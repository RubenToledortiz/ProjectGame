using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movimiento_player1 : MonoBehaviour
{

    public bool isTiempo = true;
    private CharacterController cc_player1;
    public GameObject go_invencible;
    public GameObject go_enemigomele;
    public GameObject go_enemigodistancia;
    public GameObject go_enemigomele1;
    public GameObject go_enemigomele2;
    public GameObject go_enemigomele3;
    public GameObject go_aviso;
    private float f_velocidad_jugador = 8.0f;
    private Vector3 v3_gravedad = new Vector3(0, -9.8f, 0);
    private Vector3 v3_mov_horizontal;
    private float f_fuerza_salto = 8.0f;
    private Vector3 v3_altura_salto;
    private bool b_tocar_suelo;
    private float f_muerte = -15f;
    private Vector3 v3_inicio;
    public GameObject go_sonido_salto;
    public GameObject go_sonido_respawn;
    public mover_plataforma mover_plat;
    private float f_velocidad_plataforma = 50f;
    public Gestion_estados ge;
    public bool b_muerto = false;
    public bool b_romper = false;
    public bool b_romper1 = false;
    public bool b_premio = false;
    public bool b_invencible = false;
    public bool b_desaparecer = false;
    public bool b_final = false;
    public bool b_ceilingPlayer = false;
    public bool b_invulnerabilidad = false;
    private Color[] colors = new Color[] { Color.green, Color.red, Color.white };
    public checkpoint ch;
    GameObject techo;
    GameObject techo1;
 public Animator anim_animacion;


    // Start is called before the first frame update
    void Start()
    {

        cc_player1 = GetComponent<CharacterController>();
        techo = GameObject.FindWithTag("romper");
        techo1 = GameObject.FindWithTag("romper1");
   
       

    }

    // Update is called once per frame
    void Update()
    {
        // comprobar si esta tocando el suelo o no 
        b_tocar_suelo = cc_player1.isGrounded;

        //resetear la gravedad a 0 para que no se acumule 
        if (b_tocar_suelo == true && v3_altura_salto.y < 0)
        {
            v3_altura_salto.y = 0f;
        }



        //hacer que se mueva solo en las X 
        if (ge.b_derecha == true)
        {
            anim_animacion.SetBool("b_caminar",false);
            anim_animacion.SetFloat("velX",1);
            v3_mov_horizontal = new Vector3(1, 0, 0);
            
        }
        if (ge.b_derecha == false && ge.b_bot == false)
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

        cc_player1.Move((v3_altura_salto * Time.deltaTime) + v3_mov_horizontal * Time.deltaTime * f_velocidad_jugador);

        //girarlo 
        if (v3_mov_horizontal != Vector3.zero)
        {
            cc_player1.transform.forward = v3_mov_horizontal;
        }

        // salto del personaje
        if (ge.b_bot == true && b_tocar_suelo == true)
        {
             anim_animacion.SetFloat("velY",2);
             anim_animacion.SetBool("b_caminar",false);
             anim_animacion.SetFloat("velX",(float)0.3);
    
            Instantiate(go_sonido_salto);
            v3_altura_salto += Vector3.up * f_fuerza_salto;

        }
        else
        {
            anim_animacion.SetFloat("velY",0);
            ge.b_bot = false;
            v3_altura_salto += v3_gravedad * Time.deltaTime;

        }


        
        //respawn del personaje
        if (transform.position.y < f_muerte)
        {
            b_muerto = true;
        }

        //mover la plataforma
        if (ge.b_arriba == true && ge.b_tocando == true)
        {

            mover_plat.v3_mov_plafatorma = Vector3.up * f_velocidad_plataforma * Time.deltaTime;

        }
        else if (ge.b_dreta == true && ge.b_tocando == true)
        {
            mover_plat.v3_mov_plafatorma = Vector3.right * f_velocidad_plataforma * Time.deltaTime;
        }

        else if (ge.b_abajo == true && ge.b_tocando == true)
        {
            mover_plat.v3_mov_plafatorma = Vector3.down * f_velocidad_plataforma * Time.deltaTime;
        }
        else if (ge.b_esquerra == true && ge.b_tocando == true)
        {
            mover_plat.v3_mov_plafatorma = Vector3.left * f_velocidad_plataforma * Time.deltaTime;

        }

        if (b_muerto == true)
        {

            ch.loadData();
        }


        if (b_romper == true)
        {
            techo.SetActive(false);
        }

        if (b_romper1 == true)
        {
            techo1.SetActive(false);
        }

        if (b_premio == true)
        {
            go_invencible.SetActive(true);
           
        }

        if (b_invencible == true && b_desaparecer == true && b_premio == false)
        {

            go_invencible.SetActive(false);
            aviso();
            inmortal();

        }

        if (b_final == true)
        {

            SceneManager.LoadScene("menu_creditos");
            Time.timeScale = 1;
        }

        if (b_invulnerabilidad == true) {
            go_enemigomele.SetActive(false);
            go_enemigodistancia.SetActive(false);
            go_enemigomele1.SetActive(false);
            go_enemigomele2.SetActive(false);
            go_enemigomele3.SetActive(false);
        }

    }



    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (b_invulnerabilidad == false) {
            if (hit.transform.tag == "enemigo_melee" || hit.transform.tag == "proyectil")
            {
                
                b_muerto = true;
            }
            else
                b_muerto = false;
        }
       


        if (hit.transform.tag == "romper")
        {

            b_romper = true;
        }
        else
            b_romper = false;

        if (hit.transform.tag == "romper1")
        {

            b_romper1 = true;
        }
        else
            b_romper1 = false;


        if (hit.transform.tag == "premio")
        {

            b_premio = true;
        }
        else
            b_premio = false;

        if (hit.transform.tag == "invencible")
        {

            b_invencible = true;
            b_desaparecer = true;
            b_premio = false;
            

        }
        else
            b_invencible = false;

        if (hit.transform.tag == "puerta")
        {

            b_final = true;
        }
        else
            b_final = false;

       


    }

    public void inmortal()
    {
        StartCoroutine(invulnerabilidad());
    }

    IEnumerator invulnerabilidad()
    {
        int i = 1;

        b_invulnerabilidad = true;
        GetComponent<Renderer>().material.color = colors[i];
        i++;
        yield return new WaitForSeconds(10);

        b_invulnerabilidad = false;
        go_enemigomele.SetActive(true);
        go_enemigodistancia.SetActive(true);
        go_enemigomele1.SetActive(true);
        go_enemigomele2.SetActive(true);
        go_enemigomele3.SetActive(true);

        if (i == colors.Length)
        {
            i = 4;
        }
        GetComponent<Renderer>().material.color = colors[i];


    }

    public void aviso()
    {
        StartCoroutine(textoAviso());
    }

    IEnumerator textoAviso()
    {
  


        go_aviso.SetActive(true);
        yield return new WaitForSeconds(5);
        go_aviso.SetActive(false);
      


    }
}





