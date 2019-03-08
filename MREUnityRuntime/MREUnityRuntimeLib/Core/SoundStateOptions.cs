// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
namespace MixedRealityExtension
{
    /// <summary>
    /// Modifiable Sound Instance Options
    /// </summary>
    public class SoundStateOptions
    {
        /// <summary>
        /// pitch offset in halftones (0=default, 12=one octave higher, -12=one octave lower)
        /// </summary>
        public float? Pitch;

        /// <summary>
        /// volume multiplier, (0.0-1.0, where 0.0=no sound, 1.0=maximum). Default to 1.0
        /// </summary>
        public float? Volume;

        /// <summary>
        /// repeat the sound when ended, or turn it off after playing once. Default to false
        /// </summary>
        public bool? Looping;

        /// <summary>
        /// pause or unpause the sound. Default to false
        /// </summary>
        public bool? paused;

        /// <summary>
        /// the amount that sound pitch is modified when moving towards/away from sound source.
        /// For music and speech, set this to 0, but for regular objects set to 1.0 or higher. Default to 1.0
        /// /// </summary>
        public float? Doppler;

        /// <summary>
        /// Specify how much a sound is non-directional (playing the same volume in each speaker regardless of facing direction)
        /// vs directional (playing only in the speakers that are pointing towards the sound source).
        /// This can be used to make sounds seem more "wide".
        /// It is also useful for multi-channel sounds (such as music), because a fully directional sound will always sound like mono.
        /// Default to 0.0. For music and ambient looping sounds, set this between 0.5 and 1.0.
        /// </summary>
        public float? Spread;

        /// <summary>
        /// Sounds will play at full volume until user is this many meters away, and then volume will decrease logarithmically
        /// Default to 1.0. For sound that needs to fill up a large space (like a concert), increase this number.
        /// </summary>
        public float? RolloffStartDistance;

    }
}
