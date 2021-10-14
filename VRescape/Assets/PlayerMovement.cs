using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    /// <summary>
    /// 플레이어가 이동하고 있는지 체크
    /// </summary>
    public bool moveCheck = true;

    /// <summary>
    /// 이동속도
    /// </summary>
    [SerializeField]
    public float moveSpeed = 5;

    [SerializeField]
    private float jumpSpeed = 4f;

    [SerializeField]
    static public float gravity = 10f;

    /// <summary>
    /// 세로 화면 전환
    /// </summary>
    [SerializeField]
    float speedH = 1.0f;

    /// <summary>
    /// 가로 화면 전환
    /// </summary>
    [SerializeField]
    float speedV = 1.0f;

    float yaw = 0.0f;
    private float pitch = 0.0f;

    Vector3 moveDirection = Vector3.zero;
    CharacterController character;

    /// <summary>
    /// 현재 위치
    /// </summary>
    private Transform crPos;


    private void Start() {
        character = GetComponent<CharacterController>();
        crPos = gameObject.transform;
    }
    // Update is called once per frame
    void Update() {
        crPos = gameObject.transform;
        CommonMove();
        Mouse_Screen();
    }

    /// <summary>
    /// shift스킬로 형체가 변했을 때 계산 되는 움직임
    /// </summary>
    public void ChangeMove() {
        if (gravity > 0)
            gravity = 0f;
        moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        moveDirection = transform.TransformDirection(moveDirection);
        moveDirection *= moveSpeed * 1.2f;
        character.Move(moveDirection * Time.deltaTime);
    }


    /// <summary>
    /// 앞뒤, 좌우 이동
    /// </summary>


    private void CommonMove() {

        if (gravity != 10)
            gravity = 10;
        if (character.isGrounded) {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);
            moveDirection *= moveSpeed;
            if (Input.GetKeyDown(KeyCode.Space)) {
                moveDirection.y = jumpSpeed;
            }
        }
        moveCheck = moveDirection.magnitude > 1f;
        moveDirection.y -= gravity * Time.deltaTime;
        character.Move(moveDirection * Time.deltaTime);
    }
    /// <summary>
    /// 마우스를 통한 화면 전환
    /// </summary>
    private void Mouse_Screen() {

        yaw += speedH * Input.GetAxis("Mouse X");

        // 플레이어의 x축이 35f를 넘어가면 더 이상 기울여지지 않음
        pitch -= Mathf.Abs(gameObject.transform.rotation.eulerAngles.x) <= 35
            || Mathf.Abs(gameObject.transform.rotation.eulerAngles.x) >= 325 ?
            speedV * Input.GetAxis("Mouse Y") : pitch / 20;

        transform.eulerAngles = new Vector3(pitch, yaw, 0.0f);
    }
}
    