using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DraggableItem : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    public Image image;
    Transform parentAfterDrag;
    public Image DropTarget;
    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("begin drag");
        DropTarget.enabled = true;
        parentAfterDrag = transform.parent;
        transform.SetParent(transform.root);
        transform.SetAsLastSibling();
        image.raycastTarget = false;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("dragging");
        transform.position = Input.mousePosition;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("end drag");
        DropTarget.enabled = false;
        transform.SetParent(parentAfterDrag);
        image.raycastTarget = true;
    }
}
