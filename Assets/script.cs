using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class script : MonoBehaviour
{
    public TMP_InputField nro1;
    public TMP_InputField nro2;
    public TextMeshProUGUI textResultado;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SumarYMostrarResultado()
    {
        int num1 = int.Parse(nro1.text);
        int num2 = int.Parse(nro2.text);
        textResultado.text = (num1 + num2).ToString();
    }
}
