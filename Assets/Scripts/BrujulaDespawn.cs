using UnityEngine;

public class BrujulaDespawn : MonoBehaviour
{

    [SerializeField] private GameObject GPSTracker;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GPSTracker.GetComponent<ScriptGPS>().isSpawned)
        {
            this.gameObject.SetActive(false);
        }
    }
}
