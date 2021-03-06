﻿using System.Collections.Generic;

namespace TehPers.CoreMod.Api.Extensions {
    public static class NumberExtensions {
        /// <summary>Converts the number into bytes from lowest order byte to highest order byte.</summary>
        /// <param name="source">The number to convert.</param>
        /// <returns>The bytes in the number, from lowest to highest order.</returns>
        public static IEnumerable<byte> GetBytes(this int source) {
            const int bits = 32;
            const int bitsPerByte = 4;
            for (int i = 0; i < bits / bitsPerByte; i++) {
                yield return (byte) source;
                source >>= bitsPerByte;
            }
        }

        /// <summary>Converts the number into bytes from lowest order byte to highest order byte.</summary>
        /// <param name="source">The number to convert.</param>
        /// <returns>The bytes in the number, from lowest to highest order.</returns>
        public static IEnumerable<byte> GetBytes(this uint source) {
            const int bits = 32;
            const int bitsPerByte = 4;
            for (int i = 0; i < bits / bitsPerByte; i++) {
                yield return (byte) source;
                source >>= bitsPerByte;
            }
        }
    }
}