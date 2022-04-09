using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator animator;
    private GroundDetector groundDetector;
    public float jumpForce;
    public float moveSpeed;
    private float moveInputOffset = 0.1f;
    Vector2 move;

    int _direction; // +1 : right, -1 : left
    public int direction
    {
        set
        {
            if(value < 0)
            {
                _direction = -1;
                transform.eulerAngles = new Vector3(0, 180f, 0);
            }
            else
            {
                _direction = 1;
                transform.eulerAngles = Vector3.zero;
            }
        }

        get
        {
            return _direction;
        }
    }

    public PlayerState state;
    public JumpState jumpState;
    public FallingState fallingState;
    public RunState runState;

    private float jumpTime = 0.1f;
    private float jumpTimer;

    private void Awake()
    {
        // 두개 차이 확인 필요
        //tr = GetComponent<Transform>();
        //tr = transform;

        rb = GetComponent<Rigidbody2D>();
        animator = GetComponentInChildren<Animator>();
        groundDetector = GetComponent<GroundDetector>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");

        // 방향전환
        if(h < 0)
        {
            direction = -1;
        }
        else if(h > 0)
        {
            direction = 1;
        }

        if(Mathf.Abs(h) > moveInputOffset)
        {
            move.x = h;

            if (state == PlayerState.Idle)
            {
                ChangePlayerState(PlayerState.Run);
            }
        }
        else
        {
            move.x = 0;

            if(state == PlayerState.Run)
            {
                ChangePlayerState(PlayerState.Idle);
            }
        }

        // 점프 키
        if (Input.GetKeyDown(KeyCode.LeftAlt))
        {
            if(groundDetector.isDetected && state != PlayerState.Jump && state != PlayerState.Falling)
            {
                /*rb.velocity = new Vector2(rb.velocity.x, 0);
                rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
                state = PlayerState.Jump;*/

                /*state = PlayerState.Jump;
                jumpState = JumpState.Prepare;*/

                ChangePlayerState(PlayerState.Jump);
            }
        }

        UpdatePlayerState();
    }

    private void FixedUpdate()
    {
        rb.position += new Vector2(move.x * moveSpeed, move.y) * Time.fixedDeltaTime;
    }

    public void ChangePlayerState(PlayerState newState)
    {
        if (state == newState) return;

        // 이전 상태 하위 머신 초기화
        switch (state)
        {
            case PlayerState.Idle:
                break;
            case PlayerState.Run:
                runState = RunState.Idle;
                break;
            case PlayerState.Jump:
                jumpState = JumpState.Idle;
                break;
            case PlayerState.Falling:
                fallingState = FallingState.Idle;
                break;
            default:
                break;
        }

        // 현재 상태 바꿈
        state = newState;

        // 현재 상태 하위 머신 준비
        switch (state)
        {
            case PlayerState.Idle:
                break;
            case PlayerState.Run:
                runState = RunState.Prepare;
                break;
            case PlayerState.Jump:
                jumpState = JumpState.Prepare;
                break;
            case PlayerState.Falling:
                fallingState = FallingState.Prepare;
                break;
            default:
                break;
        }
    }

    private void UpdatePlayerState()
    {
        switch (state)
        {
            case PlayerState.Idle:
                animator.Play("Idle");
                break;
            case PlayerState.Run:
                UpdateRunState();
                break;
            case PlayerState.Jump:
                UpdateJumpState();
                /*animator.Play("Jump");
                if (rb.velocity.y < 0)
                    state = PlayerState.Falling;*/
                break;
            case PlayerState.Falling:
                UpdateFallingState();
                /*animator.Play("Falling");
                // 끝나면 Idle로 돌아가게 하고 싶음
                if (groundDetector.isDetected)
                {
                    state = PlayerState.Idle;
                }*/
                break;
            default:
                break;
        }
    }

    private void UpdateRunState()
    {
        switch (runState)
        {
            case RunState.Idle:
                break;
            case RunState.Prepare:
                animator.Play("Run");
                runState++;
                break;
            case RunState.Casting:
                runState++;
                break;
            case RunState.OnAction:
                runState++;
                break;
            case RunState.Finish:
                ChangePlayerState(PlayerState.Idle);
                break;
            default:
                break;
        }
    }

    private void UpdateJumpState()
    {
        switch (jumpState)
        {
            case JumpState.Idle:
                break;
            case JumpState.Prepare:
                animator.Play("Jump");
                rb.velocity = new Vector2(rb.velocity.x, 0);
                rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
                jumpTimer = jumpTime;
                jumpState++;
                break;
            case JumpState.Casting:
                if (!groundDetector.isDetected)
                {
                    jumpState++;
                }
                else if(jumpTimer < 0)
                {
                    ChangePlayerState(PlayerState.Idle);
                }
                jumpTimer -= Time.deltaTime;
                break;
            case JumpState.OnAction:
                if(rb.velocity.y < 0)
                {
                    /*state = PlayerState.Falling;
                    jumpState = JumpState.Idle;*/

                    jumpState++;
                }
                break;
            case JumpState.Finish:
                ChangePlayerState(PlayerState.Falling);
                break;
            default:
                break;
        }
    }

    private void UpdateFallingState()
    {
        switch (fallingState)
        {
            case FallingState.Idle:
                break;
            case FallingState.Prepare:
                animator.Play("Falling");
                fallingState++;
                break;
            case FallingState.Casting:
                fallingState++;
                break;
            case FallingState.OnAction:
                if (groundDetector.isDetected)
                {
                    fallingState++;
                }
                break;
            case FallingState.Finish:
                ChangePlayerState(PlayerState.Idle);
                break;
            default:
                break;
        }
    }
}

public enum PlayerState
{
    Idle,
    Run,
    Jump,
    Falling
}

public enum JumpState
{
    Idle,
    Prepare,
    Casting,
    OnAction,
    Finish
}

public enum FallingState
{
    Idle,
    Prepare,
    Casting,
    OnAction,
    Finish
}

public enum RunState
{
    Idle,
    Prepare,
    Casting,
    OnAction,
    Finish
}