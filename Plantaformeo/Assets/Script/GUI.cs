using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GUI : MonoBehaviour
{

    public Text text;

    // Update is called once per frame
    void Update()
    {
        text.text = "Puntos " + Move.points.ToString();
    }
}
