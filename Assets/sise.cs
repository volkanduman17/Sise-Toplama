using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;


public class sise : MonoBehaviour 
{

    public Transform sise2;
    public TextMeshProUGUI canYazisi;
    public TextMeshProUGUI bitisYazisi;
    public int can;
    public AudioSource siseDusurme;

    private void Update()
    {
        canYazisi.text = "Can : " + can;

        if (can == 0)
        {
            bitisYazisi.text = "Oyun Bitti !\nTekrar Oynamak Ýçin Bir Tuþa Basýn";
            Time.timeScale = 0;

            if (Input.anyKeyDown)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
                Time.timeScale = 1;
            }


        }
    }

    void OnCollisionEnter2D(Collision2D temas)
    {
        float rastgele = Random.Range (-7.6f, 7.6f);


        if (temas.gameObject.tag == "Zemin")
        {
            sise2.position = new Vector3 (rastgele, 7f, 0f);
            can--;
            siseDusurme.Play();
        }
        
    }


}
