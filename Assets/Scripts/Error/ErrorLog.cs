using UnityEngine;
using UnityEngine.UI;

public class ErrorLog : MonoBehaviour
{
    private void Start()
    {
        if (ErrorStatus.isDisconnected) showDisconnectedError();
        if (ErrorStatus.isCreateRoomFailed) showCreateRoomFailedError();
        if (ErrorStatus.isJoinRoomFailed) showJoinRoomFailedError();
        if (ErrorStatus.isMasterClientSwitched) showMasterClientSwitchedError();
        if (ErrorStatus.isLobbyStatisticsUpdate) showLobbyStatisticsUpdateError();
    }

    private void showDisconnectedError()
    {
        this.GetComponent<Text>().text = "Disconnected from Server.";
        ErrorStatus.isDisconnected = false;
    }

    private void showCreateRoomFailedError()
    {
        this.GetComponent<Text>().text = "Failed to create room.";
        ErrorStatus.isCreateRoomFailed = false;
    }

    private void showJoinRoomFailedError()
    {
        this.GetComponent<Text>().text = "Failed to join room.";
        ErrorStatus.isJoinRoomFailed = false;
    }

    private void showMasterClientSwitchedError()
    {
        this.GetComponent<Text>().text = "Room Owner leaved.";
        ErrorStatus.isMasterClientSwitched = false;
    }

    private void showLobbyStatisticsUpdateError()
    {
        this.GetComponent<Text>().text = "Loby Status was updated.";
        ErrorStatus.isLobbyStatisticsUpdate = false;
    }
}
