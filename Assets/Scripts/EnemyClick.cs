using Spine.Unity;
using UnityEngine;
using UnityEngine.EventSystems;

public class EnemyClick : MonoBehaviour, IPointerClickHandler
{    
    public void OnPointerClick(PointerEventData eventData)
    {        
        Gun.registerClick(eventData);
    } 

}
