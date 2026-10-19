//using UnityEngine;
//using UnityEngine.InputSystem;

//public class PlayerController : MonoBehaviour
//{
//    public enum PlayerState
//    {
//        Normal,
//        // 필요에 따라 다른 상태 추가 가능
//    }

//    [Header("상태 설정")]
//    [SerializeField] private PlayerState currentState = PlayerState.Normal;

//    [Header("컴포넌트")]
//    [SerializeField] private CharacterController controller;
//    [SerializeField] private Animator animator;

//    [Header("이동 및 중력 설정")]
//    [SerializeField] private float gravity = -9.81f;
//    private float verticalVelocity;

//    void Update()
//    {
//        Keyboard keyboard = Keyboard.current;

//        if (keyboard == null)
//        {
//            return;
//        }

//        // 상태와 관계없이 중력은 계속 적용한다.
//        ApplyGravity();

//        // Normal 상태가 아니면 이동 입력을 받지 않는다.
//        if (currentState != PlayerState.Normal) return;

//        HandleMovement(keyboard);
//    }

//    private void ApplyGravity()
//    {
//        // 7. 기본 중력 설정
//        if (controller.isGrounded && verticalVelocity < 0f)
//        {
//            verticalVelocity = -2f;
//        }
//        else
//        {
//            verticalVelocity += gravity * Time.deltaTime;
//        }

//        controller.Move(Vector3.up * verticalVelocity * Time.deltaTime);
//    }

//    private void HandleMovement(Keyboard keyboard)
//    {
//        // 1. WASD 입력
//        Vector2 input = Vector2.zero;

//        if (keyboard.aKey.isPressed)
//            input.x -= 1f;
//        if (keyboard.dKey.isPressed)
//            input.x += 1f;
//        if (keyboard.sKey.isPressed)
//            input.y -= 1f;
//        if (keyboard.wKey.isPressed)
//            input.y += 1f;

//        // 여기에 이동 처리 로직을 추가할 수 있습니다.
//    }

//    public void ChangeState(PlayerState newState)
//    {
//        currentState = newState;

//        if (currentState != PlayerState.Normal)
//        {
//            animator.SetFloat("speed", 0);
//        }

//        Debug.Log("현재 상태 : " + currentState);
//    }
//}