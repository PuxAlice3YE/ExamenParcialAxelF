using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    //Variables Para el eje X
    [SerializeField] private float minimoX;
    [SerializeField] private float maximoX;
    public GameObject Obj;
    public float interval; 
    void Start()
    {
        InvokeRepeating("Spam",0,interval);
    }

    void Spam()
    {
    float objetoRandomX = Random.Range(minimoX, maximoX);
    Instantiate(Obj, new Vector3(objetoRandomX, 10, 0),Quaternion.identity); 
    Debug.Log("Nuevo objeto generado"); 
    }
}
