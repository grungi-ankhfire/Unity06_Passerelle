using UnityEngine;

public class Interactor : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        IInteractable interactable = other.GetComponent<IInteractable>();
        interactable?.Interact();
    }

}
