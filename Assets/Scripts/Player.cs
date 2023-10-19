using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Player : MonoBehaviour
{
    [Header("Movement")]
    [SerializeField] float speed = 1f;

    [Header("GUI")]
    [SerializeField] TextMeshProUGUI scoreCounter;

    private Vector3 _moveDir;

    public int publicscore
    {
        get 
        {
            return _score;
        }
        set 
        {
            _score = value;
            updateGui();
        }
    }

    private int _score = 0;

    public void SetMovementDirection(Vector3 newDirection) 
    {
        _moveDir = newDirection;
    }

    // Start is called before the first frame update
    void Start()
    {
        InputManager.Init(this);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += (Vector3) (speed * Time.deltaTime * _moveDir);
    }
    //Update GUI
    private void updateGui()
    {
        scoreCounter.text = _score.ToString();
    }
}
