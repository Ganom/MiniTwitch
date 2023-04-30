﻿using Microsoft.Extensions.Logging;

namespace MiniTwitch.Irc.Interfaces;

/// <summary>
/// An object used for configuring the membership client
/// </summary>
public interface IMembershipClientOptions
{
    /// <summary>
    /// The amount of outgoing JOINs allowed in a 10 second time period
    /// <para>Default value is 20</para>
    /// <para>Twitch docs: <see href="https://dev.twitch.tv/docs/irc/#rate-limits"/></para>
    /// </summary>
    int JoinRateLimit { get; }
    /// <summary>
    /// Logging destination
    /// <para>Adding a logger is not required, but highly recommended</para>
    /// </summary>
    public ILoggerFactory? Logger { get; set; }

    internal ILogger? Log => this.Logger?.CreateLogger<IrcMembershipClient>();
}
