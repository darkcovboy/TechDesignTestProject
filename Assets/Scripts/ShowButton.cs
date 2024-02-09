using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class ShowButton : MonoBehaviour, IPointerClickHandler
{
    [SerializeField] private Button _button;
    
    public void OnPointerClick(PointerEventData eventData)
    {
        _button.gameObject.SetActive(true);
    }
}
