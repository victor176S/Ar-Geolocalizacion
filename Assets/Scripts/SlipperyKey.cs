using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SlipperyKey : MonoBehaviour
{

    public int vecesPulsadas;

    public Button llave;

    public GameObject tapaCofre;

    private int posicionX;

    private int posicionY;

    /*public float velocidadBase = 200f;
    private Vector2 direccion;
    public RectTransform canvasRect;
    private bool yendoHaciaIzq = true;
    private bool yendoHaciaArriba = true;*/


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(AsignarCoords());
    }

    // Update is called once per frame
    void Update()
    {

        

        llave.transform.position = new Vector3(posicionX, posicionY, llave.transform.position.z); 

        //StartCoroutine(MovimientoLLave());
        
        // if (vecesPulsadas > 0 && vecesPulsadas < 20)
        // {
        //     float velocidad = velocidadBase + (vecesPulsadas * 20f);

        //     canvasRect.anchoredPosition += direccion * velocidad * Time.deltaTime;

        //     Vector2 pos = canvasRect.anchoredPosition;

        //     float limiteX = 860f;
        //     float limiteY = 440f;

        //     if (pos.x > limiteX || pos.x < -limiteX)
        //         direccion.x *= -1;

        //     if (vecesPulsadas >= 5)
        //     {
        //         if (pos.y > limiteY || pos.y < -limiteY)
        //             direccion.y *= -1;
        //     }

        //     llave.transform.position += (Vector3)(direccion * velocidad * Time.deltaTime);

        //     Vector3 pos = llave.transform.position;

        //     // Límites X
        //     if (pos.x > 860 || pos.x < -860)
        //     {
        //         direccion.x *= -1;
        //     }

        //     // Límites Y (solo después de 5 pulsaciones)
        //     if (vecesPulsadas >= 5)
        //     {
        //         if (pos.y > 440 || pos.y < -440)
        //         {
        //             direccion.y *= -1;
        //         }
        //     }
        // }

        
    }

    /*IEnumerator MovimientoLLave()
    {


        
    }*/

    IEnumerator AsignarCoords()
    {

        while (true)
        {
            posicionX = Random.Range(200, 2400);

            posicionY = Random.Range(200, 1200);

            Debug.Log($"PosX: {posicionX}");

            Debug.Log($"PosX: {posicionY}");

            yield return new WaitForSeconds (2 - (0.08f * vecesPulsadas));
        }
    }

    public void PulsarLlave()
    {
        if(vecesPulsadas < 21)
        {
            vecesPulsadas++;    
        }

        else
        {
            SceneManager.LoadScene(2);
        }
    }
}
