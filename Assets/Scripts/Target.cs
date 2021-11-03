using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TargetSizes
{
    Small,
    Medium,
    Large,
    //----
    COUNT
}
public class Target : MonoBehaviour
{
    public MeshRenderer meshRenderer;
    public float healthPoints = 100f;
    public float targetSize;
    public TargetSizes Tsize;
    float scaleFactor = 1;
    public float moveDistance = 500f;
    public Vector3 newPosition;
    public float speed;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        
        Setup();
        StartCoroutine(Move());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            transform.localScale = Random.insideUnitSphere;
        }

        

    }
    public void OnHit()
    {
        animator.SetTrigger("Hit");
        meshRenderer.material.color = Color.red;
        healthPoints = healthPoints - 20;
        Debug.Log(healthPoints);
        if (healthPoints == 0)
        {
            Destroy();
        }
        
    }

    public void Destroy()
    {
        animator.SetTrigger("Die");
        
        TargetManager.instance.Remove(this);
        Destroy(gameObject, 3f);
        
    }

    public void Setup()
    {
        switch (Tsize)
        {
            case TargetSizes.Small:
                if (GameManager.instance.difficulty == Difficulty.Hard)
                {
                    scaleFactor = 0.5f;
                    transform.localScale = Vector3.one * scaleFactor;
                    speed = 20f;
                    meshRenderer.material.color = Color.red;
                }

                break;
            case TargetSizes.Medium:
                scaleFactor = 1;
                transform.localScale = Vector3.one * scaleFactor;
                speed = 10f;
                meshRenderer.material.color = Color.yellow;
                
                break;
            case TargetSizes.Large:
                scaleFactor = 2.0f;
                transform.localScale = Vector3.one * scaleFactor;
                speed = 5f;
                meshRenderer.material.color = Color.green;
                
                break;
            default:
                scaleFactor = 2.0f;
                transform.localScale = Vector3.one * scaleFactor;
                speed = 5f;
                meshRenderer.material.color = Color.green;
                break;

        }
    }

    IEnumerator Move()
    {
        for (int i = 0; i < moveDistance; i++)
        {
            
            transform.Translate(Vector3.forward * speed * Time.deltaTime);
            //transform.Translate(Vector3.forward + Random.insideUnitSphere * .5f * Time.deltaTime);
            yield return null;
            
            // yield return new WaitForSeconds(2f);
            // transform.Translate(-Vector3.forward * Time.deltaTime);
        }
        for (int i = 0; i < moveDistance; i++)
        {

            transform.Translate(-Vector3.forward * Random.Range(5f,5f) * Time.deltaTime);
          
            yield return null;
        }
            yield return new WaitForSeconds(3f); 
        StartCoroutine(Move());


        
    }
    private void OnCollisionEnter(Collision collision)
    {
        
    }

}
