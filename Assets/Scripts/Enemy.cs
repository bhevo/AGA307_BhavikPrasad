using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum EnemyType
{
    OneHand,
    TwoHand,
    Archer,
    //---------
    COUNT
}
public class Enemy : MonoBehaviour
{
    float moveDistance = 500f;
    public float health;
    public EnemyType myType;
    // Start is called before the first frame update


   
    void Start()
    {
      
        StartCoroutine(Move());
        myType = (EnemyType)Random.Range(0, (int)EnemyType.COUNT);
        Setup();

    }

    // Update is called once per frame
    void Update()
    {
       /* if (Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine(Move());
        }*/


    }
    IEnumerator Move()
    {
        for (int i = 0; i < moveDistance; i++)
        {
            transform.Translate(Vector3.forward * Time.deltaTime);
            yield return null;
        }
        transform.Rotate(Vector3.up * 180);

        yield return new WaitForSecondsRealtime(3f);

        StartCoroutine(Move());



    }
    public void Setup()
    {
        switch (myType)
        {
            case EnemyType.Archer:
                health = 50f;
                break;
            case EnemyType.OneHand:
                health = 100f;
                break;
            case EnemyType.TwoHand:
                health = 200f;
                break;
            default:
                Debug.Log("invalid type selected");
                break;
        }
    }
}
