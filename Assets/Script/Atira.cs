using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Atira : MonoBehaviour
{
    public Rigidbody bocaEsqueda;
    public Rigidbody bocaDireita;
    public Rigidbody bocaCima;
    public Rigidbody bocaBaixo;
    public Rigidbody tiro;
    public float velTiro;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        atira();
    }

    void atira()
    {
        if(Input.GetButtonDown("Fire Direita")) spawnaTiro(bocaDireita, tiro, new Vector3(velTiro, 0, 0));
        if(Input.GetButtonDown("Fire Esquerda")) spawnaTiro(bocaEsqueda, tiro, new Vector3(-velTiro, 0, 0));
        if(Input.GetButtonDown("Fire Baixo")) spawnaTiro(bocaCima, tiro, new Vector3(0, 0, -velTiro));
        if(Input.GetButtonDown("Fire Cima")) spawnaTiro(bocaBaixo, tiro, new Vector3(0, 0, velTiro));
    }

    void spawnaTiro(Rigidbody boca, Rigidbody tiro, Vector3 direcao)
    {
        Rigidbody novoTiro = Instantiate(tiro, boca.transform.position, boca.transform.rotation);
        novoTiro.velocity = transform.TransformDirection(direcao);
        novoTiro.GetComponent<Tiro>().personagem = transform.gameObject;
    }
}
