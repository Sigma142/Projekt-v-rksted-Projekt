using UnityEngine;

public class DoorAnimator : MonoBehaviour
{
    public Animator anim;
    private bool isOpen = false;

    public void Toggle()
    {
        isOpen = !isOpen;
        anim.SetTrigger(isOpen ? "Open" : "Close");
    }
}
