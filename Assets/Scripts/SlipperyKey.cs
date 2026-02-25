using UnityEngine;
using UnityEngine.SceneManagement;

public class SlipperyKey : MonoBehaviour
{

    public int vecesPulsadas;

    public GameObject llave;

    public GameObject tapaCofre;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        if(vecesPulsadas > 0 && vecesPulsadas < 20)
        {
            if(llave.transform.position.x > 860)
            {
                llave.transform.position += new Vector3(-1 * (vecesPulsadas / 1.5f), 0, 0);
            }

            if(llave.transform.position.x < -860)
            {
                llave.transform.position += new Vector3(1 * (vecesPulsadas / 1.5f), 0, 0);
            }

            if (vecesPulsadas >= 5)
            {
                    if(llave.transform.position.y > 440)
                    {
                        
                        llave.transform.position += new Vector3(0, -1 * (vecesPulsadas / 2), 0);

                    }

                    if(llave.transform.position.y < -440)
                    {
                        
                        llave.transform.position += new Vector3(0, 1 * (vecesPulsadas / 2), 0);

                    }
            }
        }

        else if (vecesPulsadas == 20)
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

    public void PulsarLlave()
    {
        if(vecesPulsadas < 20)
        {
            vecesPulsadas++;    
        }
    }
}
