using TMPro;
using UnityEngine;

public class DebugTexto : MonoBehaviour
{

    public TextMeshProUGUI textoPulsos;

    public TextMeshProUGUI vecesInstanciadas;

    public TextMeshProUGUI objetoEncontrado;

    private GameObject cosas;

    private GameObject GPSTracker;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cosas = GPSTracker.GetComponent<ScriptGPS>().spawnedObject;
    }

    // Update is called once per frame
    void Update()
    {
        textoPulsos.text = cosas.GetComponent<SlipperyKey>().vecesPulsadas.ToString();

        vecesInstanciadas.text = GPSTracker.GetComponent<ScriptGPS>().vecesInstanciadas.ToString();

        if (cosas != null)

        objetoEncontrado.text = "Objeto encontrado";
    }
}
