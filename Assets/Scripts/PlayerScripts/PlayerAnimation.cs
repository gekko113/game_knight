using UnityEngine;

public class PlayerAnimation : MonoBehaviour
{
    [SerializeField] private MovementPlayer movementPlayer;
    private Animator animator;
    private const string ISRUNNING = "isRunning";
    private const string ISATTACKING = "isAttack";
    private bool canAttack = true;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        AnimationRun();
        PlayerAttackAnimation();
    }
    public void CanAttackEnable()
    {
        canAttack = true;
    }
    public void CanAttackDisable()
    {
        canAttack = false;
    }

    private void AnimationRun()
    {
        if (movementPlayer.IsRunning())
        {
            animator.SetBool(ISRUNNING, true);
        }
        else
        {
            animator.SetBool(ISRUNNING, false);
        }
    }

    private void PlayerAttackAnimation()
    {
        if (Input.GetMouseButtonDown(0) && canAttack)
        {
            animator.SetTrigger(ISATTACKING);
        }
    }
}
