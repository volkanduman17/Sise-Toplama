using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class kutuHareketi : MonoBehaviour
{

    public float hiz;
    public Transform sise;
    public int puan;
    public TextMeshProUGUI puanYazisi;
    public AudioSource siseAlma;
    



    void Update()
    {

        puanYazisi.text = "Puan : " + puan;

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(-hiz * Time.deltaTime, 0f, 0f);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(hiz * Time.deltaTime, 0f, 0f);
        }




    }

    void OnCollisionEnter2D(Collision2D temas)
    {
        float rastgele = Random.Range(-7.6f, 7.6f);

        if(temas.gameObject.tag == "Sise")
        {
            sise.position = new Vector3 (rastgele, 7f, 0f);
        }

        puan += 5;
        siseAlma.Play();


    }


}
