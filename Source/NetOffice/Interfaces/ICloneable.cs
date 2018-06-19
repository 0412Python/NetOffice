﻿using System;
using NetOffice.Exceptions;

namespace NetOffice
{
    /// <summary>
    /// Supports cloning, which creates a deep copy of an ICOMObject instance.
    /// The new cloned instance having the same parent and shares the underlying com proxy with the origin instance trough a reference-counter-based lifetime system.
    /// The used lifetime system is implemented by NetOffice and works exactly like the COM Standard and the RCW System(which implements also its own reference counter).
    /// NetOffice want free the underlying proxy when there is no ICOMObject instance anymore that holding the underlying proxy.
    /// Remarks: It is necessary to call Dispose for an instance in NetOffice, the Garbage Collector isn't an option here.
    /// See NetOffice Lifecyle Tutorials for further informations.
    /// </summary>
    /// <typeparam name="T">ICOMObject type implementation as any</typeparam>
    /// <exception cref="CloneException">An unexpected error occured. See inner exception(s) for details.</exception>
    public interface ICloneable<T>  where T : class, ICOMObject
    {
        /// <summary>
        /// Creates a new ICOMObject instance that is a copy of the current instance
        /// </summary>
        /// <returns> A new ICOMObject that is a copy of this instance</returns>
        T Clone();
    }
}
