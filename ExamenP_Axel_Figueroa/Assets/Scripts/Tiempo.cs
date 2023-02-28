using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Tiempo : MonoBehaviour
{
    float timer = 60f;
    [SerializeField] private TMP_Text Reloj;
    public GameObject Player;
    public GameObject Reiniciar;
    [SerializeField] private TMP_Text GameOver; 
    void Start()
    {
        Reiniciar.gameObject.SetActive(false); 
        GameOver.enabled= false;
    }
    void Update()
    {
      timer = timer - Time.deltaTime;  
      if(timer <= 0)
      {
           Player.gameObject.SetActive(false);
           Reiniciar.gameObject.SetActive(true); 
           GameOver.enabled= true; 
      }
      
      Reloj.text = "Tiempo Restante:" + timer.ToString("f0");
      
    }
}
