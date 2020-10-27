using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class PlayerControl : NetworkBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    [Command]
    void CmdMove(Vector2 tempV2)
    {
        transform.Translate(new Vector3(0, 0, tempV2.x * Time.deltaTime));
        transform.Rotate(new Vector3(0, tempV2.y, 0) * Time.deltaTime * 100);
    }
    private void Move()
    {
        Vector2 tempV2 = new Vector2();
        if (Input.GetKey(KeyCode.W) 
            || Input.GetMouseButton(0))
        {
            tempV2.x = 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            tempV2.x = -1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            tempV2.y = -1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            tempV2.y = 1;
        }
        CmdMove(tempV2);
    }

    // Update is called once per frame
    void Update()
    {
        if (isLocalPlayer)
        {
            Move();
        }
    }
}
