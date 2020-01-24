using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundSlideshow : MonoBehaviour
{
    public Sprite[] images = new Sprite[6];
    [Tooltip("Time, in seconds")]
    public FloatReference timePerImage;
    public IntReference startImage;
    private float timer = 0.0f;
    private Image image;
    private int currentImage;

    void Awake()
    {
        image = gameObject.GetComponent<Image>();
    }

    private void OnEnable()
    {
        currentImage = (startImage.Value - 1);
        timer = 0.0f;
        image.sprite = images[currentImage];
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer > timePerImage.Value)
        {
            timer -= timePerImage.Value;
            AdvanceImage();
        }
    }

    public void AdvanceImage()
    {
        currentImage += 1;
        if (currentImage > (images.Length - 1))
        {
            currentImage = 0;
        }

        image.sprite = images[currentImage];
    }
}
