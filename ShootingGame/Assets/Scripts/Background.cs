using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    public Material bgMaterial;
    public float scrollSpeed = 2.0f;

    void Update()
    {
        Vector2 dir = Vector2.up;
        bgMaterial.mainTextureOffset += dir * scrollSpeed * Time.deltaTime; 
    }
}
