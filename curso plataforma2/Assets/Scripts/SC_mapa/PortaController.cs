using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortaController : MonoBehaviour
{
    private Animator meuAnim;

    [SerializeField] private string destino;

    // Start is called before the first frame update
    void Start()
    {
        meuAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AbrindoPorta()
    {
        meuAnim.SetTrigger("abrir");
    }
    public void FechandoPorta()
    {
        meuAnim.SetTrigger("fechar");
    }

    //Indo para o meu destino
    public void IndoDestino()
    {
        //Acessando o GameManager
        FindObjectOfType<GameManager>().MudaCena(destino);
    }
}
