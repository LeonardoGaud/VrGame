using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Sparo : MonoBehaviour
{
    public GameObject Proiettile;
    public Transform spawnSparo;
    public float velocitaSparo = 20;

    // Start is called before the first frame update
    void Start()
    {
        XRGrabInteractable bho = GetComponent<XRGrabInteractable>();
        bho.activated.AddListener(Spara);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Spara(ActivateEventArgs args)
    {
        GameObject spawn = Instantiate(Proiettile);
        spawn.transform.position = spawnSparo.position;
        spawn.GetComponent<Rigidbody>().velocity = spawnSparo.forward * velocitaSparo;
        Destroy(spawn, 5);
    }
}
