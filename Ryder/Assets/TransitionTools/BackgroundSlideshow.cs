using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundSlideshow : MonoBehaviour
{
    public Sprite[] images = new Sprite[6];
    [Tooltip("Time, in seconds")]
    public IntReference timePerImage;
    public IntReference startImage;
    private Image image;
    private int currentImage;

    void Awake()
    {
        image = gameObject.GetComponent<Image>();
        currentImage += (startImage.Value - 1);
    }

    private void OnEnable()
    {
        NewImage();
    }

    IEnumerator NewImage()
    {
        currentImage += 1;
        if (currentImage > images.Length)
        {
            currentImage = 0;
        }

        image.sprite = images[currentImage];

        yield return new WaitForSeconds(timePerImage.Value);

        NewImage();
    }
}
