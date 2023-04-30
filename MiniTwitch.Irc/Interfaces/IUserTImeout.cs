﻿namespace MiniTwitch.Irc.Interfaces;

/// <summary>
/// Contains information about a user timeout
/// </summary>
public interface IUserTimeout
{
    /// <summary>
    /// The duration of the timeout
    /// </summary>
    TimeSpan Duration { get; }
    /// <summary>
    /// The target user of the timeout
    /// </summary>
    IBanTarget Target { get; }
    /// <summary>
    /// The channel where the event occurred
    /// </summary>
    IBasicChannel Channel { get; }
    /// <summary>
    /// Milliseconds Unix timestamp of when the event occurred
    /// </summary>
    long TmiSentTs { get; }
}
