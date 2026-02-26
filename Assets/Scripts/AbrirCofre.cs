using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AbrirCofre : MonoBehaviour
{
    public GameObject tapaCofre;

    public void AbriTapa()
    {
        if (tapaCofre.gameObject.transform.localEulerAngles.x < 140)
        {
            tapaCofre.gameObject.transform.localRotation = Quaternion.Euler(0.5f + tapaCofre.gameObject.transform.localEulerAngles.x, 0,0);
        }

        if(tapaCofre.gameObject.transform.localEulerAngles.x >= 140)
        {
            SceneManager.LoadScene(2);
        }
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        if (tapaCofre.gameObject.transform.localEulerAngles.x < 140)
        {
            tapaCofre.gameObject.transform.localRotation = Quaternion.Euler(0.5f + tapaCofre.gameObject.transform.localEulerAngles.x, 0,0);
        }

        if(tapaCofre.gameObject.transform.localEulerAngles.x >= 140)
        {
            StartCoroutine(loadFinish());
        }
    }

    private IEnumerator loadFinish()
    {
        yield return new WaitForSecondsRealtime(3f);
        SceneManager.LoadScene(2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}