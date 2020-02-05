using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StreetNameCycle : MonoBehaviour
{
    [Tooltip("Time for each street name, in seconds")]
    public FloatReference displayTime;
    [Tooltip("Adds randomness from 0 to this value to display time")]
    public FloatReference displayTimeRandom;
    public string[] streetNames;
    private TextMeshProUGUI textMesh;
    private float timer;
    private float displayTimeActual;

    void Awake()
    {
        textMesh = gameObject.GetComponent<TextMeshProUGUI>();
    }

    private void OnEnable()
    {
        RandomStreetName();
        CalculateDisplayTime();
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer > displayTimeActual)
        {
            timer -= displayTimeActual;
            RandomStreetName();
            CalculateDisplayTime();
        }
    }

    void RandomStreetName()
    {
        textMesh.text = streetNames[Random.Range(0, (streetNames.Length - 1))];
    }

    void CalculateDisplayTime()
    {
        displayTimeActual = displayTime.Value + Random.Range(0.0f, displayTimeRandom.Value);
    }
}
