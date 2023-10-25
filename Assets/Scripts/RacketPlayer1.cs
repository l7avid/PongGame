using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RacketPlayer1 : MonoBehaviour
{

    public float movementSpeed;

    private void FixedUpdate()
    {
        //'Vertical' is the name of the vertical axis in Unity. Edit -> Project settings -> Input Manager -> Axis
        float verticalValue = Input.GetAxisRaw("Vertical");
        //In the same path as above you must create another axis for the player 2 within your unity project settings

        GetComponent<Rigidbody2D>().velocity = new Vector2(0, verticalValue) * movementSpeed;
    }
}
