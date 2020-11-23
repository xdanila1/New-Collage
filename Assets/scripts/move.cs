using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move : MonoBehaviour
{
    public float xShift;
    public float speed;
    public float gravity;
    private CharacterController Character;
    void Start()
    {
        xShift = 1.5f;
        speed = 3;
        gravity = -9.8f;
        
    }

    void Update()
    {
        Character = GetComponent<CharacterController>();
        if (Character == null) Debug.Log("Не обнаружен контроллер");
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");
        
        if (Input.GetKey(KeyCode.LeftShift))
        {
            Vector3 move = new Vector3(x, gravity, y) * Time.deltaTime * (speed*xShift);
            move = transform.TransformDirection(move);
            Character.Move(move);
        }
        else
        {
            Vector3 move = new Vector3(x, gravity, y) * Time.deltaTime * speed;
            move = transform.TransformDirection(move);
            Character.Move(move);
        }
        
       
        
    }
}
