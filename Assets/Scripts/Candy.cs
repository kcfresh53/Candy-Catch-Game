using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Candy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        hideCandy();
    }

    private void hideCandy()
    {
        // get each child sprite
        Transform[] candySprites = GetComponentsInChildren<Transform>();
        foreach (Transform x in candySprites) 
        {
            //hide sprite
            x.gameObject.SetActive(false);
        }
        selectCandy();
    }

    private void selectCandy()
    {
        int selectedCandy = Random.Range(0, 5);
        transform.GetChild(selectedCandy).gameObject.SetActive(true);
        Debug.Log(selectedCandy.ToString());
    }
}
