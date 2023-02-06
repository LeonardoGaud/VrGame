using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MovimentoManoSinistra : MonoBehaviour
{
    public InputActionProperty AnimazionePinch;
    public InputActionProperty AnimazionePresa;
    public Animator AnimazioneMano;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float ValorePinch = AnimazionePinch.action.ReadValue<float>();
        AnimazioneMano.SetFloat("Trigger", ValorePinch);

        float ValorePresa = AnimazionePresa.action.ReadValue<float>();
        AnimazioneMano.SetFloat("Grip", ValorePresa);
    }
}
