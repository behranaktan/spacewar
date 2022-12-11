using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{

    MeshRenderer mr;



    // Start is called before the first frame update
    void Start()
    {
        mr = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        float y = 0.4f*Time.time;
        mr.material.SetTextureOffset("_MainTex", new Vector2(0, y));
    }
}
