using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace NetworkScripts {
  public class NetworkTick {
    /* Configuratuins */

    private static int _ticksPerSecond = 100;

    /* Initial variables */
    private static int _currentNetworkTick            = 0;
    private static int _currentNetworkTickOffset      = 0;
    private static int _currentNetworkTickLocalOffset = 0;


    /***************************************/
    /* Static variables for project access */
    /***************************************/

    /* Tick int variables */
    public static int TickPerSecond        => _ticksPerSecond;
    public static int ServerTick           => _currentNetworkTick;
    public static int ClientOffsetTick     => _currentNetworkTickOffset;
    public static int ClientPredictionTick => _currentNetworkTick + _currentNetworkTickOffset;

    /* Tick based time float variables */
    public static float ServerTime           => (float) _currentNetworkTick / _ticksPerSecond;
    public static float ClientOffsetTime     => (float) _currentNetworkTickOffset / _ticksPerSecond;
    public static float ClientPredictionTime => (float) (_currentNetworkTick + _currentNetworkTickOffset) / _ticksPerSecond;


    /* Network Tick Control functions  */
    public int GetServerTickPerSecond              => _currentNetworkTick;
    public int SetServerTickPerSecond(int newTick) => _currentNetworkTick = newTick;

    public int  GetServerTick                                 => _currentNetworkTick;
    public int  SetServerTick(int newTick)                    => _currentNetworkTick = newTick;
    public int  GetClientTickOffset()                         => _currentNetworkTickOffset;
    public void SetClientTickOffset(int newNetworkTickOffset) => _currentNetworkTickOffset = newNetworkTickOffset;
    public int  GetTickLocalOffset()                          => _currentNetworkTickLocalOffset;
    public int  SetTickLocalOffset(int newTickOffset)         => _currentNetworkTickLocalOffset = newTickOffset;


    /* to avoid accessing static methos when NetworkTick is instanciated */
    public int   GetPredictionTick()       => _currentNetworkTick + _currentNetworkTickOffset;
    public float GetServerTime()           => (float) _currentNetworkTick / _ticksPerSecond;
    public float GetServerPredictionTime() => (float) (_currentNetworkTick + _currentNetworkTickOffset) / _ticksPerSecond;
  }
}