using UnityEngine;
using UnityEngine.EventSystems;

public class AnimationPlayerClick : MonoBehaviour, IPointerClickHandler
{
    private const string JumpTriggerName = "Jump";
    private readonly int Jump = Animator.StringToHash(JumpTriggerName);

    [SerializeField] private Animator _animator;


    public void OnPointerClick(PointerEventData eventData)
    {
        _animator.SetTrigger(Jump);
    }
}
