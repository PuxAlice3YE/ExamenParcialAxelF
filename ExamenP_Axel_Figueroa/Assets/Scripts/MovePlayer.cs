using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class MovePlayer : MonoBehaviour
{
    //Movimiento
    [SerializeField]private float speed;
    //Puntuacion
    float Puntuacion = 0f;
    [SerializeField] private TMP_Text Contador; 
    public GameObject Reiniciar;
    [SerializeField] private TMP_Text GameOver; 

    
    void Start()
    {
        Reiniciar.gameObject.SetActive(false); 
        GameOver.enabled= false; 
    }


    void Update()
    {
        if (Input.GetKey(KeyCode.D))  
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.A)) 
        {
            transform.position += Vector3.left * speed * Time.deltaTime;
        }
        Contador.text = "Tú puntuación es: " + Puntuacion.ToString("f0");
    }
    
    private void OnTriggerEnter(Collider other) 
    {
        if(other.tag == "Bomb")    
        {
           gameObject.SetActive(false);
           Reiniciar.gameObject.SetActive(true); 
           GameOver.enabled= true; 
        }
        if(other.tag == "Apple")    
        {
           Puntuacion = Puntuacion + 1f;
        }
    }
    
    public void Respawn()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
