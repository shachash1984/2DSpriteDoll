using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    private Animator _animator;
    public float speed = 7.5f;


    void Awake()
    {
        _animator = GetComponent<Animator>();
    }

    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        Move(x);
        Animate(x);
    }

    void Move(float axis)
    {        
        transform.Translate(new Vector3(axis, 0, 0) * Time.deltaTime * speed);        
    }

    void Animate(float axis)
    {
        if(axis != 0)
        {
            if (axis < 0)
                transform.localScale = new Vector3(-1f, 1f, 1f);
            else if (axis > 0)
                transform.localScale = Vector3.one;

            _animator.SetBool("isMoving", true);
        }
        else
            _animator.SetBool("isMoving", false);
    }
}
