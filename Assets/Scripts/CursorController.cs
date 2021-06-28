using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] Player playerMove;
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {

        
    }
    public void ActiveCursor(){
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
        playerMove.enabled = false;

    }

    public void DesactiveCursor(){
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
        playerMove.enabled = true;
    }
}
