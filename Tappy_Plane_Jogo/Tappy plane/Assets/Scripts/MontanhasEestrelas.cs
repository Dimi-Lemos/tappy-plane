using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MontanhasEestrelas : MonoBehaviour
{
    public GameObject[] montanhas;
    public float tempoEntreAsMontanhas;
    public float tempoAtualMontanhas;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tempoAtualMontanhas -= Time.deltaTime;

        if(tempoAtualMontanhas <= 0)
        {
            int montanhaAleatoria = Random.Range(0, montanhas.Length);

            Instantiate(montanhas[montanhaAleatoria], transform.position, transform.rotation);
            tempoAtualMontanhas = tempoEntreAsMontanhas;
        }
    }
}
