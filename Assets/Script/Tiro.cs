using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tiro : MonoBehaviour
{
    public float tempo;
    public GameObject personagem;
    public GameObject tiro;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, tempo);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        
        if(collision.gameObject != personagem || collision.gameObject != tiro)
        {
            Debug.Log(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
