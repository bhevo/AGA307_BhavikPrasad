using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public MeshRenderer meshRenderer;
    public float healthPoints = 100f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnHit()
    {
        meshRenderer.material.color = Color.red;
        healthPoints = healthPoints - 20;
        Debug.Log(healthPoints);
        if (healthPoints == 0)
        {
            Destroy(gameObject);
        }
        
    }
}
