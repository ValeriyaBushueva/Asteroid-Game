using System;
using UnityEngine;
using UnityEngine.UI;


public class ApplyModifications : MonoBehaviour
{
    [SerializeField] private Button doButton;
    [SerializeField] private Button undoButton;

    private Command commandToClick;

    private void Start()
    {
        commandToClick = new ApplyPlayerModificationsCommand(FindObjectOfType<Player>());

        doButton.onClick.AddListener(OnDoClick);
        undoButton.onClick.AddListener(OnUndoClick);
    }

    private void OnDestroy()
    {
        doButton.onClick.RemoveListener(OnDoClick);
        undoButton.onClick.RemoveListener(OnUndoClick);
    }

    private void OnDoClick() => commandToClick.Do();

    private void OnUndoClick() => commandToClick.Undo();
}