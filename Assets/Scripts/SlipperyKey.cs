using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SlipperyKey : MonoBehaviour
{

    public int vecesPulsadas;

    public Button llave;

    public GameObject tapaCofre;

    public float velocidadBase = 200f;
    private Vector2 direccion;
    public RectTransform canvasRect;
    private bool yendoHaciaIzq;
    private bool yendoHaciaArriba;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        direccion = Random.insideUnitCircle.normalized;

        
    }

    // Update is called once per frame
    void Update()
    {

        StartCoroutine(MovimientoLLave());
        
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

    IEnumerator MovimientoLLave()
    {

        if(vecesPulsadas >= 0 && vecesPulsadas < 20)
        {

            if (yendoHaciaIzq)
            {
                while (true)
                {
                
                if(llave.transform.position.x > 90)
                {
                    llave.transform.position += new Vector3(-1 * (vecesPulsadas / 1.5f), 0, 0);

                    yield return new WaitForSeconds(0.03f);

                    if (llave.transform.position.x < 90)
                        {
                            yendoHaciaIzq = false;

                            break;
                        }
                }
                }
            }

            if (!yendoHaciaIzq)
            {
                while (true)
                {
                
                if(llave.transform.position.x < 1820)
                {
                    llave.transform.position += new Vector3(-1 * (vecesPulsadas / 1.5f), 0, 0);

                    yield return new WaitForSeconds(0.03f);

                    if (llave.transform.position.x > 1820)
                        {
                            yendoHaciaIzq = false;

                            break;
                        }
                }
                }
            }

            if (yendoHaciaArriba)
            {
                while (true)
                {
                
                if(llave.transform.position.y < 440)
                {
                    llave.transform.position += new Vector3(0, -1 * (vecesPulsadas / 2), 0);

                    yield return new WaitForSeconds(0.03f);

                    if (llave.transform.position.y > 440)
                        {
                            yendoHaciaIzq = false;

                            break;
                        }
                }
                }
            }

            if (!yendoHaciaArriba)
            {
                while (true)
                {
                
                if(llave.transform.position.y > 85)
                {
                    llave.transform.position += new Vector3(0, 1 * (vecesPulsadas / 2), 0);

                    yield return new WaitForSeconds(0.03f);

                    if (llave.transform.position.x < 85)
                        {
                            yendoHaciaIzq = false;

                            break;
                        }
                }
            }
            }

        

                if (vecesPulsadas == 20)
                {

                llave.gameObject.SetActive(false);

                if (tapaCofre.gameObject.transform.localEulerAngles.x < 140)
                {
                    tapaCofre.gameObject.transform.localRotation = Quaternion.Euler(0.5f + tapaCofre.gameObject.transform.localEulerAngles.x, 0,0);
                }

                if(tapaCofre.gameObject.transform.localEulerAngles.x >= 140)
                {
                
                    SceneManager.LoadScene(2);

                }
            }

            }
        

        
    }

    public void PulsarLlave()
    {
        if(vecesPulsadas < 20)
        {
            vecesPulsadas++;    
        }
    }
}
