using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ULVania.Hero
{
    public class IdleState : HeroState
    {
        private Animator animator;

        public IdleState(HeroController hero, HeroStateMachine fsm) 
            : base(hero, fsm)
        {
            animator = hero.GetComponent<Animator>();
        }

        public override void OnEnter()
        {
            base.OnEnter();
            animator.SetBool("isRunning", false);
        }

        public override void OnHandleInput()
        {
            base.OnHandleInput();

            if (Input.GetAxisRaw("Horizontal") != 0)
            {
                hero.Move();
            }
        }
    }

}
