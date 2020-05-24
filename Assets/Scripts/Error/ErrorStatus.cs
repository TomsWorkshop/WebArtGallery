using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ErrorStatus
{
    public static bool isDisconnected = false;
    public static bool isCreateRoomFailed = false;
    public static bool isJoinRoomFailed = false;
    public static bool isMasterClientSwitched = false;
    public static bool isLobbyStatisticsUpdate = false;
}
