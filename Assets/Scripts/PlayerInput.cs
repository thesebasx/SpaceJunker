using UnityEngine;

public class PlayerInput : MonoBehaviour {
    Vector2 inputVector;
    ShipMove shipMove;

    private void Start() {
        shipMove = GetComponent<ShipMove>();
    }
    private void Update() {
        
		
		
		inputVector =  Camera.main.ScreenToWorldPoint(Input.mousePosition);
        shipMove.ShipMovement(inputVector);
    }
}