using UnityEngine;

public class Interactable : MonoBehaviour {

    public float radius = 3f;
    public Transform interactionTransform;

    bool isFocus = false;
    Transform player;

    bool hasInteracted = false;

    public virtual void Interact ()
    {
        //This method is ment to be overwritten
        Debug.Log("Interacting with " + transform.name);
    }

    void Update ()
    {
        if (isFocus && !hasInteracted)
        {
            float distance = Vector3.Distance(player.position, interactionTransform.position);
            if(distance <= radius)
            {
                //Debug.Log("ITERACT"); // Remove to remove log message
                hasInteracted = true;
                Interact();
            }
        }
    }

    public void OnFocused (Transform playerTransform)
    {
        isFocus = true;
        player = playerTransform;
        hasInteracted = false;
    }

    public void OnDefocused()
    {
        isFocus = false;
        player = null;
        hasInteracted = false;
    }

    void OnDrawGizmosSelected()
    {
        if(interactionTransform == null )
        {
            interactionTransform = transform;
        }


        Gizmos.color = new Color(1, 1, 0, 0.75F);
        Gizmos.DrawWireSphere(interactionTransform.position, radius);
    }
}
