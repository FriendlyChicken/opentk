﻿//
// EffectSlotInteger.cs
//
// Copyright (C) 2019 OpenTK
//
// This software may be modified and distributed under the terms
// of the MIT license. See the LICENSE file for details.
//

using System;

namespace OpenTK.Audio.OpenAL
{
    /// <summary>
    /// A list of valid <see cref="int"/> <see cref="ALC.EFX.AuxiliaryEffectSlot(int, EffectSlotInteger, int)"/>/<see cref="ALC.EFX.GetAuxiliaryEffectSlot(int, EffectSlotInteger)"/> parameters.
    /// </summary>
    public enum EffectSlotInteger
    {
        /// <summary>
        /// This property is used to attach an Effect object to the Auxiliary Effect Slot object. After the attachment,
        /// the Auxiliary Effect Slot object will contain the effect type and have the same effect parameters that were
        /// stored in the Effect object. Any Sources feeding the Auxiliary Effect Slot will immediate feed the new
        /// effect type and new effect parameters.
        /// </summary>
        Effect = 0x0001,

        /// <summary>
        /// This property is used to enable or disable automatic send adjustments based on the physical positions of the
        /// sources and the listener. This property should be enabled when an application wishes to use a reverb effect
        /// to simulate the environment surrounding a listener or a collection of Sources.
        /// </summary>
        [Obsolete("Use EffectSlotBoolean.AuxiliarySendAuto instead.")]
        AuxiliarySendAuto = 0x0003,
    }
}
