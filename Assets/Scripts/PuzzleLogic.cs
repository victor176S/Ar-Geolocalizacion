using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PuzzleLogic : MonoBehaviour
{

    public List<int> patronGen1;

    public List<int> patronGen2;

    public List<int> patronGen3;

    public List<int> patron1;

    public List<int> patron2;

    public List<int> patron3;

    public bool BotonPulsado1;

    public bool BotonPulsado2;

    public bool BotonPulsado3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ColorMatch()
    {

        for (int i = 0; i < 3; i++)
        {
            
            if (patronGen1[0] == 0 && BotonPulsado1)
            {
            
                

            }

        }
        
        

    }

    public IEnumerator GenerateRandomPatterns()
    {
        for (int i = 0; i < 3; i++)
        {
            patronGen1.Add(Random.Range(0,3));
        }

        patron1 = patronGen1;

        for (int i = 0; i < 3; i++)
        {
            patronGen2.Add(Random.Range(0,3));
        }

        patron2 = patronGen2;

        for (int i = 0; i < 3; i++)
        {
            patronGen3.Add(Random.Range(0,3));
        }

        patron3 = patronGen3;

        yield return null;
    }

    public void BotonIzq(bool pulsado)
    {
        
        BotonPulsado1 = pulsado; 

    }

    public void BotonCentro(bool pulsado)
    {
        
       BotonPulsado2 = pulsado; 

    }

    public void BotonDer(bool pulsado)
    {
        
       BotonPulsado3 = pulsado; 

    }
}
