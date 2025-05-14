using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class parImpar : MonoBehaviour
{
    public TMP_InputField nro;
    public TextMeshProUGUI parOImpar;
    int nroPosta;
    // Start is called before the first frame update
    void Start()
    {
        parOImpar.text = "";
    }
    public void funcion()
    {
        nroPosta = int.Parse(nro.text);

        if (nro.text == "" || nroPosta < 1)
        {
            parOImpar.text = "el numero debe ser mayor a 0";
            return;
        }
        else if (nroPosta % 2 == 0)
        {
            parOImpar.text = "el nro es par";
            return;
        }
        else if (nroPosta % 2 != 0)
        {
            parOImpar.text = "el nro es impar";
            return;
        }
    }
    
}
