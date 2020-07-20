using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine;

public class ButtonEventOnDown1 : MonoBehaviour, IPointerDownHandler {

    
      public GameObject player;
    public PlayerAttack playerAttack;

    void Start()
    {
        playerAttack = player.GetComponent<PlayerAttack>();
    }
    
    public void OnButtonAttack()
    {
        playerAttack.Atak();
      
    }
    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log(this.gameObject.name + " was clicked.");
        OnButtonAttack();
    }
}
