using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using UnityEngine;

public class ButtonEventOnDown : MonoBehaviour, IPointerDownHandler {

    public PlayerMovement player;



    public void onButtonjump()
    {
        player.jump = true;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log(this.gameObject.name + " was clicked.");
        onButtonjump();
    }
}
