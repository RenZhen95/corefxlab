// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System.Diagnostics;

namespace System.Reflection.TypeLoading
{
    internal readonly struct AssemblyFileInfo
    {
        public AssemblyFileInfo(string name, bool containsMetadata, int rowIndex)
        {
            Debug.Assert(name != null);

            Name = name;
            ContainsMetadata = containsMetadata;
            RowIndex = rowIndex;
        }

        public string Name { get; }
        public int RowIndex { get; }  // 0 for manifest modoule - 1..N for other modules.
        public bool ContainsMetadata { get; }
    }
}