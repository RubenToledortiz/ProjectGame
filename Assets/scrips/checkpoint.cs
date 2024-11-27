using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class checkpoint : MonoBehaviour
{

    public Vector3 v3_posPlayer;
    public float f_posX;
    public float f_posY;
    // Start is called before the first frame update
    void Start()
    {
        loadData();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void loadData(){

        f_posX = PlayerPrefs.GetFloat("posicionX");
        f_posY = PlayerPrefs.GetFloat("posicionY");

        v3_posPlayer.x = f_posX;
       v3_posPlayer.y = f_posY;

       transform.position = v3_posPlayer;
    }

    public void SaveData(){

        PlayerPrefs.SetFloat("posicionX", transform.position.x);
        PlayerPrefs.SetFloat("posicionY", transform.position.y);
    }
}
