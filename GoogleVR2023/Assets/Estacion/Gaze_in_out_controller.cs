using UnityEngine;
using UnityEngine.EventSystems;

public class Gaze_in_out_controller : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (animator)
        {
            animator.SetBool("Mirando", true);
        }
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (animator)
        {
            animator.SetBool("Mirando", false);
        }
    }
}


