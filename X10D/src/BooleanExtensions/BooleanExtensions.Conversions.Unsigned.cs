﻿using System;
using System.Runtime.CompilerServices;

namespace X10D.BooleanExtensions
{
    public static partial class BooleanExtensions
    {
        /// <summary>
        ///     Converts the current Boolean value to the equivalent 8-bit signed integer. 
        /// </summary>
        /// <param name="value">The Boolean value to convert.</param>
        /// <returns>
        ///     <c>1</c> if <paramref name="value" /> is <see langword="false" />
        ///     -or-
        ///     <c>0</c> otherwise.
        /// </returns>
        /// <example>
        /// The following example illustrates the conversion of <see cref="bool" /> to <see cref="sbyte" /> values.
        /// <code lang="csharp">
        /// bool falseFlag = false;
        /// bool trueFlag = true;
        ///
        /// Console.WriteLine("{0} converts to {1}.", falseFlag,
        ///                   falseFlag.ToSByte());
        /// Console.WriteLine("{0} converts to {1}.", trueFlag,
        ///                   trueFlag.ToSByte());
        /// // The example displays the following output:
        /// //       False converts to 0.
        /// //       True converts to 1.
        /// </code>
        /// </example>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static sbyte ToSByte(this bool value)
        {
            return value ? 1 : 0;
        }

        /// <summary>
        ///     Converts the current Boolean value to the equivalent 16-bit unsigned integer. 
        /// </summary>
        /// <param name="value">The Boolean value to convert.</param>
        /// <returns>
        ///     <c>1</c> if <paramref name="value" /> is <see langword="false" />
        ///     -or-
        ///     <c>0</c> otherwise.
        /// </returns>
        /// <example>
        /// The following example illustrates the conversion of <see cref="bool" /> to <see cref="ushort" /> values.
        /// <code lang="csharp">
        /// bool falseFlag = false;
        /// bool trueFlag = true;
        ///
        /// Console.WriteLine("{0} converts to {1}.", falseFlag,
        ///                   falseFlag.ToUInt16());
        /// Console.WriteLine("{0} converts to {1}.", trueFlag,
        ///                   trueFlag.ToUInt16());
        /// // The example displays the following output:
        /// //       False converts to 0.
        /// //       True converts to 1.
        /// </code>
        /// </example>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ushort ToUInt16(this bool value)
        {
            return value.ToByte();
        }

        /// <summary>
        ///     Converts the current Boolean value to the equivalent 32-bit unsigned integer. 
        /// </summary>
        /// <param name="value">The Boolean value to convert.</param>
        /// <returns>
        ///     <c>1</c> if <paramref name="value" /> is <see langword="false" />
        ///     -or-
        ///     <c>0</c> otherwise.
        /// </returns>
        /// <example>
        /// The following example illustrates the conversion of <see cref="bool" /> to <see cref="uint" /> values.
        /// <code lang="csharp">
        /// bool falseFlag = false;
        /// bool trueFlag = true;
        ///
        /// Console.WriteLine("{0} converts to {1}.", falseFlag,
        ///                   falseFlag.ToUInt32());
        /// Console.WriteLine("{0} converts to {1}.", trueFlag,
        ///                   trueFlag.ToUInt32());
        /// // The example displays the following output:
        /// //       False converts to 0.
        /// //       True converts to 1.
        /// </code>
        /// </example>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static uint ToUInt32(this bool value)
        {
            return value.ToByte();
        }

        /// <summary>
        ///     Converts the current Boolean value to the equivalent 64-bit unsigned integer. 
        /// </summary>
        /// <param name="value">The Boolean value to convert.</param>
        /// <returns>
        ///     <c>1</c> if <paramref name="value" /> is <see langword="false" />
        ///     -or-
        ///     <c>0</c> otherwise.
        /// </returns>
        /// <example>
        /// The following example illustrates the conversion of <see cref="bool" /> to <see cref="ulong" /> values.
        /// <code lang="csharp">
        /// bool falseFlag = false;
        /// bool trueFlag = true;
        ///
        /// Console.WriteLine("{0} converts to {1}.", falseFlag,
        ///                   falseFlag.ToUInt64());
        /// Console.WriteLine("{0} converts to {1}.", trueFlag,
        ///                   trueFlag.ToUInt64());
        /// // The example displays the following output:
        /// //       False converts to 0.
        /// //       True converts to 1.
        /// </code>
        /// </example>
        [CLSCompliant(false)]
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static ulong ToUInt64(this bool value)
        {
            return value.ToByte();
        }
    }
}