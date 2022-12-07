using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BackgroundScrolling : MonoBehaviour
{
    private RawImage image;

    [SerializeField]
    private float speed;

    private void Start()
    {
        image = GetComponent<RawImage>();
    }

    private void Update()
    {
        image.uvRect = new Rect(image.uvRect.position + Vector2.right * speed * Time.deltaTime, image.uvRect.size);
    }
}
