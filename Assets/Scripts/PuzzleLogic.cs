using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PuzzleLogic : MonoBehaviour
{

    public List<int> patronGen1;

    public List<int> patronGen2;

    public List<int> patronGen3;

    public List<int> patron1;

    public List<int> patron2;

    public List<int> patron3;

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
            patronGen2.Add(Random.Range(0,3));
        }

        patron3 = patronGen3;

        yield return null;
    }

    public IEnumerator BotonesAnimacion(int turno)
    {
        switch (turno)
        {
            case 1:

                for (int i = 0; i < patron1.Count; i++)
                    {

                        this.gameObject.transform.GetChild(patron1[i]);


                    
                    }

                break;

            case 2:

            case 3:
            
            default:

            //waos

                break;
        }

        yield return null;
    }
}
