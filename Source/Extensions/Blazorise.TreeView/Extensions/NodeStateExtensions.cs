﻿#region Using directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blazorise.TreeView.Internal;
#endregion

namespace Blazorise.TreeView.Extensions
{
    internal static class NodeStateExtensions
    {
        public static async IAsyncEnumerable<TreeViewNodeState<TNode>> ToNodeStates<TNode>( this IEnumerable<TNode> nodes,
            Func<TNode, Task<bool>> hasChildNodesAsync,
            Func<TNode, bool> hasChildNodes,
            bool expanded )
        {
            foreach ( var node in nodes ?? Enumerable.Empty<TNode>() )
            {
                var hasChildren = hasChildNodesAsync is not null
                    ? await hasChildNodesAsync( node )
                    : hasChildNodes( node );

                yield return new TreeViewNodeState<TNode>( node, hasChildren, expanded );
            }
        }
    }
}