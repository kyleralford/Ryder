using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class StreetNameCycle : MonoBehaviour
{
    public bool isStreetNameRandom = false;
    [Tooltip("This value does nothing if street names are set to random")]
    public int streetNameIndex = 0;
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
        if (isStreetNameRandom)
        {
            RandomStreetName();
        }
        else
        {
            NextStreetName();
        }
        CalculateDisplayTime();
    }

    void Update()
    {
        timer += Time.deltaTime;

        if (timer > displayTimeActual)
        {
            timer -= displayTimeActual;
            if (isStreetNameRandom)
            {
                RandomStreetName();
            }
            else
            {
                NextStreetName();
            }
            

            CalculateDisplayTime();
        }
    }

    void RandomStreetName()
    {
        textMesh.text = streetNames[Random.Range(0, (streetNames.Length - 1))];
    }

    void NextStreetName()
    {
        textMesh.text = streetNames[streetNameIndex];
        streetNameIndex += 1;
        if (streetNameIndex > streetNames.Length)
        {
            streetNameIndex = 0;
        }
    }

    void CalculateDisplayTime()
    {
        displayTimeActual = displayTime.Value + Random.Range(0.0f, displayTimeRandom.Value);
    }
}
