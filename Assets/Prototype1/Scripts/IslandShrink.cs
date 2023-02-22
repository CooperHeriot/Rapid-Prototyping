using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IslandShrink : MonoBehaviour
{
    public SpawnManager SM;
    public Vector3 scale;
    // Start is called before the first frame update
    void Start()
    {
        scale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3(scale.x - SM.waveNuber /2, scale.y - SM.waveNuber / 2, scale.z - SM.waveNuber / 2);
    }
}
