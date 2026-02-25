using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SlipperyKey : MonoBehaviour
{

    public int vecesPulsadas;

    public Button llave;

    public GameObject cofre;

    private bool yendoHaciaIzq;
    private bool yendoHaciaArriba;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

        StartCoroutine(MovimientoLLave());       
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
                Instantiate(cofre);
                // cofre.AbrirTapa();

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
