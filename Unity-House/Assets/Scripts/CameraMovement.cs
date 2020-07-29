using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
	private float _speed;
	private float _angularSpeed = 1f;
	private float _rotationAngleX;
	private float _rotationAngleY;
	private CharacterController _character;
	
    // Start is called before the first frame update
    void Start()
    {
        _speed = 0f;
		_rotationAngleX = 0f;
		_rotationAngleY = 0f;
		_character = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
		//get mouse coordinates
        float mouse_x = Input.GetAxis("Mouse X");
		float mouse_y = Input.GetAxis("Mouse Y");
		
		if(Input.GetKey(KeyCode.W))
			_speed +=0.01f;
		else if (Input.GetKey(KeyCode.S))
			_speed -=0.01f;

		_rotationAngleX = mouse_x * _angularSpeed;
		_rotationAngleY = mouse_y * _angularSpeed;
		
		transform.Rotate(new Vector3(-_rotationAngleY, _rotationAngleX, 0));
		
		
		//transform.Translate(Vector3.forward * Time.deltaTime * _speed);		
		//Using character controller instead of transformations
		Vector3 direction = transform.TransformDirection(Vector3.forward * Time.deltaTime * _speed);
		_character.Move(direction);
		}
}
