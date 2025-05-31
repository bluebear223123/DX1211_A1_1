using UnityEngine;
using UnityEngine.InputSystem;

public class Movement : MonoBehaviour
{
    [SerializeField] Vector2 speed;

    [SerializeField] Rigidbody2D body;


    void Awake()
    {
        body = GetComponent<Rigidbody2D>();
    }
    
    void FixedUpdate()
    {
        //move the car
       var moveAction = InputSystem.actions.FindAction("Move");
       var moveValue = moveAction.ReadValue<Vector2>();

       body.AddForce(Vector2.Scale(moveValue, speed));
    }
}
