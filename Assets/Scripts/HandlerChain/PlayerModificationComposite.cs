using System;
using System.Collections.Generic;
using UnityEngine;


public class PlayerModificationComposite : MonoBehaviour
{
    [SerializeField] private Player player;

    [SerializeField] private List<PlayerHandler> playerHandlers;

    private void Start()
    {
        InitializeHandlers();
    }

    private void InitializeHandlers()
    {
        foreach (var playerHandler in playerHandlers)
        {
            playerHandler.Initialize(player);
        }
    }

    public void Handle()
    {
        foreach (var playerHandler in playerHandlers)
        {
            playerHandler.Handle();
        }
    }
    
    public void Unhandle()
    {
        foreach (var playerHandler in playerHandlers)
        {
            playerHandler.Handle();
        }
    }
}