﻿/*
 * TagEnums.cs
 * Author: Samuel Vargas
 */

using System;

namespace Tags {

  [Serializable]
  public enum TagType : int {
    Agent = 0,
    Geometry = 1,
    Device = 2,
    Sensor = 3,
    PickUp = 4,
  }

  [Serializable]
  public enum SensorId : int {
    ObstructionZone = 0,
    ItemPickUpZone = 1,
    LedgeDetectionSensor = 2,
  }

  [Serializable]
  public enum AgentId {
    Player = 0,
  }

  [Serializable]
  public enum GeometryId {
    Cube = 0,
    Stairs = 1,
  }

  [Serializable]
  public enum DeviceId {
    LaserSender = 0,
    ColorChanger = 1,
    Exit = 3,
    ColorGate = 4,
    Laser = 5,
  }

  [Serializable]
  public enum PickUpId {
    ElevenHalfKgWeight = 0,
    Crate = 1,
  }

}