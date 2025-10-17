using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerwalk : MonoBehaviour
{
   

    
        // The animator for our character.
        public Animator animController;

        // The object's sprite renderer.
        public SpriteRenderer guySpriteRenderer;

        // Update is called once per frame
        void Update()
        {
            // if we move left
            if (Input.GetKey(KeyCode.A))
            {
                // we set the bool that we are moving in the animator.
                animController.SetBool("isMoving", true);

                // Flip the Sprite
                guySpriteRenderer.flipX = true;
            }
            // if we move right.
            else if (Input.GetKey(KeyCode.D))
            {

                animController.SetBool("isMoving", true);

                // set the sprite back to it's default.
                guySpriteRenderer.flipX = false;
            }
            else
            {
                // set the anim controller to not moving, returning to idle animation.
                animController.SetBool("isMoving", false);
            }
        }
    }

