using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Command 
{
    public abstract void Execute(Animator animator);
}

public class DoJumping:Command
{
    public override void Execute(Animator animator)
    {
        animator.SetTrigger("isJumping");
    }
}

public class DoPunching : Command
{
    public override void Execute(Animator animator)
    {
        animator.SetTrigger("isPunching");
    }
}

public class MoveForward : Command
{
    public override void Execute(Animator animator)
    {
        animator.SetTrigger("isWalking");
    }
}

public class DoKicking : Command
{
    public override void Execute(Animator animator)
    {
        animator.SetTrigger("isKicking");
    }
}
