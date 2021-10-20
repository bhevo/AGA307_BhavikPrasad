using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeapnSwitching : MonoBehaviour
{
    public int selectedProjectile = 0;
    // Start is called before the first frame update
    void Start()
    {
        SelectProjectile();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if (selectedProjectile >= transform.childCount - 1)
                selectedProjectile = 0;
            else
            selectedProjectile++;
            SelectProjectile();
           // selectedProjectile = 0;
        }

       /* if (Input.GetKeyDown(KeyCode.Alpha2) && transform.childCount >=2)
        {         
            selectedProjectile = 1;
        }*/
    }
    void SelectProjectile()
    {
        int i = 0;
        foreach (Transform projectile in transform)
        {
            if (i == selectedProjectile)
                projectile.gameObject.SetActive(true);
            else
                projectile.gameObject.SetActive(false);
            i++;
        }
    }
}
