using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Player : MonoBehaviour
{

    public float multiplier = 5f;
    public TMP_Text text;
    private float _axis = 0.0f;
    int score = 0;

    public float Axis
    {
        get { return _axis; }
        private set { _axis = value; }
    }

    Vector3 v = new Vector3(0, 0, 0);

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        Axis = Input.GetAxis("Horizontal");

        v = transform.position;
        v.x += Axis * multiplier * Time.deltaTime;
        transform.position = v;
    }

    public void IncrementScore()
    {
        score++;
        text.text = score.ToString();
    }
}
