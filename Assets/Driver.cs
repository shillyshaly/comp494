using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;
    SpriteRenderer sprite;
    SpriteRenderer sprite2;
    public GameObject greenLight;
    public GameObject yellowLight;

    void Start()
    {
        sprite = greenLight.GetComponent<SpriteRenderer>();
        sprite2 = yellowLight.GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        MoveCar();
    }

    void MoveCar(){
        float moveAmount = moveSpeed * Time.deltaTime;

        if(sprite.color  == Color.green || sprite2.color == Color.yellow){
            transform.Translate(0, moveAmount, 0);
        }
    }
}
