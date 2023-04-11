using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class textureScroll : MonoBehaviour
{
    public float XSpeed = 0.5f;
    public float YSpeed = 0.5f;
    private Renderer R;
    // Start is called before the first frame update
    void Start()
    {
        R = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float OffsetX = Time.time * XSpeed;
        float OffsetY = Time.time * YSpeed;

        R.material.mainTextureOffset = new Vector2(OffsetX, OffsetY);
    }
}
